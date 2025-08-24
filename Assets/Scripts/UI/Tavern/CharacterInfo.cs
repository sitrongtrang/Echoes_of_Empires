using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text _nameText;
    // private TMP_Text _descriptionText;
    [SerializeField] private TMP_Text _hpText;
    [SerializeField] private TMP_Text _damageText;
    [SerializeField] private TMP_Text _attackRangeText;
    [SerializeField] private TMP_Text _movementRangeText;
    [SerializeField] private TMP_Text _costText;
    [SerializeField] private GameObject _portrait;
    [SerializeField] private TMP_Text _fragmentsEquivalentText;
    [SerializeField] private TMP_Text _orText;
    [SerializeField] private Button _addToGalleryButton;

    public void SetInfo(BaseCharacterConfig config, RarityMapperSO rarityMapper)
    {
        if (string.IsNullOrEmpty(config.Name))
            _nameText.text = "???";
        else
            _nameText.text = config.Name;

        _nameText.color = rarityMapper.GetColor(config.Rarity);

        _hpText.text = $"{config.BaseHealth}";
        _damageText.text = $"{config.BaseDamage}";
        _attackRangeText.text = $"{config.BaseAttackRange}";
        _movementRangeText.text = $"{config.BaseMovementRange}";
        _costText.text = $"{config.BaseCost}";
        _fragmentsEquivalentText.text = $"{config.FragmentsEquivalent}\nFragments";

        if (_portrait != null && config.Portrait != null)
        {
            Image portraitFrame = _portrait.GetComponent<Image>();
            if (portraitFrame != null)
            {
                portraitFrame.sprite = rarityMapper.GetFrame(config.Rarity);
            }
            Image portraitImage = _portrait.transform.Find("Image").GetComponent<Image>();
            portraitImage.sprite = config.Portrait;
        }

        if (CharacterGallery.Instance.OwnedCharacters.Contains(config))
        {
            _orText.gameObject.SetActive(false);
            _addToGalleryButton.gameObject.SetActive(false);
        }
        else
        {
            _orText.gameObject.SetActive(true);
            _addToGalleryButton.gameObject.SetActive(true);
            _addToGalleryButton.onClick.RemoveAllListeners();
            _addToGalleryButton.onClick.AddListener(
                () =>
                {
                    CharacterGallery.Instance.AddCharacter(config);
                    gameObject.SetActive(false);
                }
            );
        }
    }
}