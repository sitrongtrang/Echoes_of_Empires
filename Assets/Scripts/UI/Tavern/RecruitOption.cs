using UnityEngine;
using UnityEngine.UI;

public class RecruitOption : MonoBehaviour
{
    [SerializeField] private GameObject _portrait;
    private BaseUnitConfig _unitConfig;
    private CharacterInfo _characterInfo;

    void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(DisplayInfo);
    }

    void OnDisable()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();
    }

    public void Initialize(BaseUnitConfig unitConfig, CharacterInfo characterInfo)
    {
        _unitConfig = unitConfig;
        _characterInfo = characterInfo;

        if (_portrait != null && unitConfig.Portrait != null)
        {
            Image portraitFrame = _portrait.GetComponent<Image>();
            if (portraitFrame != null)
            {
                portraitFrame.sprite = GameManager.Instance.RarityMapper.GetFrame(unitConfig.Rarity);
            }
            Image portraitImage = _portrait.transform.Find("Portrait").GetComponent<Image>();
            portraitImage.sprite = unitConfig.Portrait;
        }
    }

    void DisplayInfo()
    {
        if (_unitConfig != null)
        {
            _characterInfo.SetInfo(_unitConfig, GameManager.Instance.RarityMapper);
        }
    }
} 