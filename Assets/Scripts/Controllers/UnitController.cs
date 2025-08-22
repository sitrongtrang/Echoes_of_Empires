using System;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    [Header("Unit Configuration")]
    public BaseUnitConfig Config { get; private set; }
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    [Header("Unit Components")]
    private UnitHealth _health;
    private UnitAttack _attack;
    private UnitMovement _movement;
    private int _actionPoints;

    public UnitHealth Health => _health;
    public UnitAttack Attack => _attack;
    public UnitMovement Movement => _movement;
    public int ActionPoints
    {
        get => _actionPoints;
        set
        {
            if (value < 0)
                throw new OutOfAPException("Action points cannot be negative.");
            _actionPoints = value;
        }
    }

    public event Action OnTurnEnded;

    #region Unity Lifecycle
    #endregion

    #region Initialization
    public void Initialize(BaseUnitConfig config)
    {
        Config = config;

        _spriteRenderer = GetComponent<SpriteRenderer>();
        if (_spriteRenderer && Config.UnitSprite)
            _spriteRenderer.sprite = Config.UnitSprite;

        _animator = GetComponent<Animator>();
        if (_animator && Config.Anim)
            _animator.runtimeAnimatorController = Config.Anim;

        _health = new UnitHealth(this);
        _attack = new UnitAttack(this);
        _movement = new UnitMovement(this);
        _actionPoints = GameConstants.BASE_ACTION_POINTS;
    }
    #endregion

}