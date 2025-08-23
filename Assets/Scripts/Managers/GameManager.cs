using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private RarityMapperSO _rarityMapper;
    public RarityMapperSO RarityMapper => _rarityMapper;
    public static GameManager Instance { get; private set; }
    private LuaClient _luaClient;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
        // Init();
    }

    void Init()
    {
        _luaClient = this.gameObject.AddComponent<LuaClient>();
    }
}