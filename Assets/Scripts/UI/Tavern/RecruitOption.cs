using UnityEngine;
using UnityEngine.UI;

public class RecruitOption : MonoBehaviour
{
    private Sprite _emptyFrame;
    private BaseCharacterConfig _unitConfig;
    private CharacterInfo _characterInfo;

    void OnEnable()
    {
        Button button = GetComponentInChildren<Button>(true);
        if (button != null)
            button.onClick.AddListener(DisplayInfo);
    }

    void OnDisable()
    {
        Button button = GetComponentInChildren<Button>(true);
        if (button != null)
            button.onClick.RemoveAllListeners();
    }

    public void Initialize(BaseCharacterConfig unitConfig, CharacterInfo characterInfo, Sprite emptyFrame = null)
    {
        if (_emptyFrame == null)
            _emptyFrame = emptyFrame;
    
        _unitConfig = unitConfig;
        _characterInfo = characterInfo;
        
        Button button = GetComponentInChildren<Button>(true);
        button.onClick.RemoveAllListeners();
        
        Image portraitFrame = GetComponent<Image>();
        Image portraitImage = transform.Find("Portrait").GetComponent<Image>();

        if (unitConfig != null)
        {
            button.onClick.AddListener(DisplayInfo);
            button.gameObject.SetActive(true);

            portraitFrame.sprite = GameManager.Instance.RarityMapper.GetFrame(unitConfig.Rarity);
            portraitImage.sprite = unitConfig.Portrait;
        }
        else
        {
            button.gameObject.SetActive(false);
            portraitFrame.sprite = emptyFrame;
            portraitImage.sprite = null;
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
        Button button = GetComponentInChildren<Button>(true);
        button.onClick.RemoveAllListeners();
        button.gameObject.SetActive(false);
        Image portraitFrame = GetComponent<Image>();
        portraitFrame.sprite = _emptyFrame;
        Image portraitImage = transform.Find("Portrait").GetComponent<Image>();
        portraitImage.sprite = null;
    }
} 