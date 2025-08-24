using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseCharacterConfig", menuName = "Scriptable Objects/BaseCharacterConfig")]
public class BaseCharacterConfig : ScriptableObject
{
    [SerializeField] private string _name;
    public string Name => _name;

    [SerializeField] private Sprite _unitSprite;
    public Sprite UnitSprite => _unitSprite;

    [SerializeField] private Sprite _portrait;
    public Sprite Portrait => _portrait;

    [SerializeField] private AnimatorController _anim;
    public AnimatorController Anim => _anim;

    [SerializeField] private string _description;
    public string Description => _description;

    [SerializeField] private int _baseHealth;
    public int BaseHealth => _baseHealth;

    [SerializeField] private int _baseDamage;
    public int BaseDamage => _baseDamage;

    [SerializeField] private int _baseAttackRange;
    public int BaseAttackRange => _baseAttackRange;

    [SerializeField] private int _baseMovementRange;
    public int BaseMovementRange => _baseMovementRange;

    [SerializeField] private int _baseCost;
    public int BaseCost => _baseCost;

    [SerializeField] private BaseSkillConfig[] _skills;
    public BaseSkillConfig[] Skills => _skills;

    [SerializeField] private UnitRarity _rarity;
    public UnitRarity Rarity => _rarity;

    [SerializeField] private BaseCharacterConfig[] _upgradeForms;
    public BaseCharacterConfig[] UpgradeForms => _upgradeForms;

    // [SerializeField] private int _fragmentsEquivalent;
    // public int FragmentsEquivalent => _fragmentsEquivalent;
}
