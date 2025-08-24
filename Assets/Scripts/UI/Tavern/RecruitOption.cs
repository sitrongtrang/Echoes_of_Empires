using UnityEngine;
using UnityEngine.UI;

public class RecruitOption : MonoBehaviour
{
    private Sprite _emptyFrame;
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

    public void Initialize(BaseCharacterConfig unitConfig, CharacterInfo characterInfo, Sprite emptyFrame = null)
    {
        if (_emptyFrame == null)
            _emptyFrame = emptyFrame;
    
        _unitConfig = unitConfig;
        _characterInfo = characterInfo;

        if (unitConfig.Portrait != null)
        {
            Button button = GetComponentInChildren<Button>();
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(DisplayInfo);
            button.gameObject.SetActive(true);
            Image portraitFrame = GetComponent<Image>();
            if (portraitFrame != null)
                portraitFrame.sprite = GameManager.Instance.RarityMapper.GetFrame(unitConfig.Rarity);
            Image portraitImage = transform.Find("Portrait").GetComponent<Image>();
            portraitImage.sprite = unitConfig.Portrait;
        }
    }

    void DisplayInfo()
    {
        if (_unitConfig != null && _characterInfo != null)
        {
            _characterInfo.gameObject.SetActive(true);
            _characterInfo.SetInfo(_unitConfig, GameManager.Instance.RarityMapper, this);
        }
    }

    public void ClearOption()
    {
        _unitConfig = null;
        _characterInfo = null;
        Button button = GetComponentInChildren<Button>();
        button.onClick.RemoveAllListeners();
        button.gameObject.SetActive(false);
        Image portraitFrame = GetComponent<Image>();
        portraitFrame.sprite = _emptyFrame;
        Image portraitImage = transform.Find("Portrait").GetComponent<Image>();
        portraitImage.sprite = null;
    }
} 