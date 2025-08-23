using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterInfo : MonoBehaviour
{
    [SerializeField] private RarityMapperSO _rarityMapper;
    [SerializeField] private TMP_Text _nameText;
    // private TMP_Text _descriptionText;
    [SerializeField] private TMP_Text _hpText;
    [SerializeField] private TMP_Text _damageText;
    [SerializeField] private TMP_Text _attackRangeText;
    [SerializeField] private TMP_Text _movementRangeText;
    [SerializeField] private TMP_Text _costText;
    [SerializeField] private GameObject _portrait;

    public void SetInfo(BaseUnitConfig config, RarityMapperSO rarityMapper)
    {
        if (string.IsNullOrEmpty(config.Name))
            _nameText.text = "???";
        else
            _nameText.text = config.Name;

        // if (string.IsNullOrEmpty(config.Description))
        //     _descriptionText.text = "...";
        // else
        //     _descriptionText.text = config.Description;

        _hpText.text = $"{config.BaseHealth}";
        _damageText.text = $"{config.BaseDamage}";
        _attackRangeText.text = $"{config.BaseAttackRange}";
        _movementRangeText.text = $"{config.BaseMovementRange}";
        _costText.text = $"{config.BaseCost}";

        if (_portrait != null && config.Portrait != null)
        {
            Image portraitFrame = _portrait.GetComponent<Image>();
            if (portraitFrame != null)
            {
                portraitFrame.sprite = rarityMapper.GetFrame(config.Rarity);
            }
            Image portraitImage = _portrait.transform.Find("Portrait").GetComponent<Image>();
            portraitImage.sprite = config.Portrait;
        }
    }
}