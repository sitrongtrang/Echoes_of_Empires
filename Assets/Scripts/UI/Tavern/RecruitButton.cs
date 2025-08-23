using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecruitButton : MonoBehaviour
{
    [SerializeField] private BaseUnitConfig[] _unitConfigs;
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
        List<BaseUnitConfig> recruits = GetRandomUnits(numRecruits);
        _recruitOptionList.DisplayOptions(recruits);
    }

    private List<BaseUnitConfig> GetRandomUnits(int numRecruits)
    {
        List<BaseUnitConfig> randomUnits = new();

        for (int i = 0; i < numRecruits; i++)
        {
            int randomIndex = Random.Range(0, _unitConfigs.Length);
            BaseUnitConfig randomUnit = _unitConfigs[randomIndex];
            randomUnits.Add(randomUnit);
        }

        return randomUnits;
    }

}