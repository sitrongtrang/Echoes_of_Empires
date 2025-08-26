using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private RarityMapperSO _rarityMapper;
    public RarityMapperSO RarityMapper => _rarityMapper;
    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}