using UnityEngine;
using UnityEngine.UI;

public class RecruitOption : MonoBehaviour
{
    private BaseCharacterConfig _unitConfig;
    private CharacterInfo _characterInfo;

    void OnEnable()
    {
        GetComponentInChildren<Button>().onClick.AddListener(DisplayInfo);
    }

    void OnDisable()
    {
        GetComponentInChildren<Button>().onClick.RemoveAllListeners();
    }

    public void Initialize(BaseCharacterConfig unitConfig, CharacterInfo characterInfo)
    {
        _unitConfig = unitConfig;
        _characterInfo = characterInfo;

        if (unitConfig.Portrait != null)
        {
            Image portraitFrame = GetComponent<Image>();
            if (portraitFrame != null)
            {
                portraitFrame.sprite = GameManager.Instance.RarityMapper.GetFrame(unitConfig.Rarity);
            }
            Image portraitImage = transform.Find("Portrait").GetComponent<Image>();
            portraitImage.sprite = unitConfig.Portrait;
        }
    }

    void DisplayInfo()
    {
        if (_unitConfig != null)
        {
            _characterInfo.gameObject.SetActive(true);
            _characterInfo.SetInfo(_unitConfig, GameManager.Instance.RarityMapper);
        }
    }
} 