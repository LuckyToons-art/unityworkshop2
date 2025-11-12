using UnityEngine;
using TMPro;

public class CollectibleCounter : MonoBehaviour
{
    public static CollectibleCounter Instance; // Singleton so collectibles can easily access it

    [Header("UI Reference")]
    public TextMeshProUGUI counterText;

    private int collectibleCount = 0;

    private void Awake()
    {
        // Set up singleton
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddCollectible(int amount = 1)
    {
        collectibleCount += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (counterText != null)
            counterText.text = $"Collectibles: {collectibleCount}";
    }
}
