using UnityEngine;

[CreateAssetMenu(fileName = "BaseSkillConfig", menuName = "Scriptable Objects/BaseSkillConfig")]
public class BaseSkillConfig : ScriptableObject
{
    [SerializeField] private string _skillName;
    public string SkillName => _skillName;

    [SerializeField] private Sprite _icon;
    public Sprite Icon => _icon;

    [SerializeField] private string _description;
    public string Description => _description;

    [SerializeField] private int _cooldown;
    public int Cooldown => _cooldown;
}