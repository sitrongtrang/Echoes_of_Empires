using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecruitButton : MonoBehaviour
{
    [SerializeField] private BaseCharacterConfig[] _unitConfigs;
    [SerializeField] private RecruitOptionList _recruitOptionList;
    [SerializeField] private RecruitMode _recruitMode;

    void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(Recruit);
    }

    void OnDisable()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();
    }

    public void Recruit()
    {
        int numRecruits = Mathf.Min((int)_recruitMode, GameConstants.MAX_RECRUIT_OPTIONS);
        List<BaseCharacterConfig> recruits = GetRandomUnits(numRecruits);
        _recruitOptionList.DisplayOptions(recruits);
    }

    private List<BaseCharacterConfig> GetRandomUnits(int numRecruits)
    {
        List<BaseCharacterConfig> randomUnits = new();

        for (int i = 0; i < numRecruits; i++)
        {
            int randomIndex = Random.Range(0, _unitConfigs.Length);
            BaseCharacterConfig randomUnit = _unitConfigs[randomIndex];
            randomUnits.Add(randomUnit);
        }

        return randomUnits;
    }

}