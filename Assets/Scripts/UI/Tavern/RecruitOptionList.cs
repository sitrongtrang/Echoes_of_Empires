using System.Collections.Generic;
using UnityEngine;

public class RecruitOptionList : MonoBehaviour
{
    [SerializeField] private Sprite _emptyFrame;
    [SerializeField] private GameObject _optionPrefab;
    [SerializeField] private CharacterInfo _characterInfo;
    
    public void DisplayOptions(List<BaseCharacterConfig> recruits)
    {
        for (int i = 0; i < recruits.Count; i++)
        {
            if (i >= transform.childCount)
            {
                GameObject option = Instantiate(_optionPrefab, transform);
                option.transform.SetParent(transform);
                RecruitOption recruitOption = option.AddComponent<RecruitOption>();
                recruitOption.Initialize(recruits[i], _characterInfo, _emptyFrame);
            }
            else
            {
                GameObject option = transform.GetChild(i).gameObject;
                option.SetActive(true);
                if (option.TryGetComponent<RecruitOption>(out var recruitOption))
                {
                    recruitOption.Initialize(recruits[i], _characterInfo, _emptyFrame);
                }
                else
                {
                    recruitOption = option.AddComponent<RecruitOption>();
                    recruitOption.Initialize(recruits[i], _characterInfo, _emptyFrame);
                }
            }
        }

        for (int i = recruits.Count; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}