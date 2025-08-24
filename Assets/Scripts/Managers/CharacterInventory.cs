using System.Collections.Generic;
using UnityEngine;

public class CharacterGallery : MonoBehaviour
{
    private List<BaseCharacterConfig> _ownedCharacters = new();
    private Dictionary<BaseCharacterConfig, int> _characterFragments = new();

    public List<BaseCharacterConfig> OwnedCharacters => _ownedCharacters;
    public static CharacterGallery Instance { get; private set; }

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

    public void AddCharacter(BaseCharacterConfig character)
    {
        if (!_ownedCharacters.Contains(character))
            _ownedCharacters.Add(character);
        else
            AddFragments(character, GameManager.Instance.RarityMapper.GetFragmentsEquivalent(character.Rarity));
    }

    public void AddFragments(BaseCharacterConfig character, int fragments)
    {
        if (_characterFragments.ContainsKey(character))
            _characterFragments[character] += fragments;
        else
            _characterFragments[character] = fragments;
    }
}