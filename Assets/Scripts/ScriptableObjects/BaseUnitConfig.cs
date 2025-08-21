using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseUnitConfig", menuName = "Scriptable Objects/BaseUnitConfig")]
public class BaseUnitConfig : ScriptableObject
{
    [SerializeField] private string _name;
    public string Name => _name;

    [SerializeField] private Mesh _model;
    public Mesh Model => _model;

    [SerializeField] private Sprite _avatar;
    public Sprite Avatar => _avatar;

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

    [SerializeField] private BaseSkillConfig[] _skills;
    public BaseSkillConfig[] Skills => _skills;

    [SerializeField] private UnitRarity _rarity;
    public UnitRarity Rarity => _rarity;

    [SerializeField] private UnitCulture _culture;
    public UnitCulture Culture => _culture;

    [SerializeField] private UnitClass[] _classes;
    public UnitClass[] Classes => _classes;

    public UnitCultureGroup CultureGroup => CultureData.GetGroup(_culture);
}
