using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int value = 1;
    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collected)
        {
            collected = true;

            // Add to counter if the manager exists
            if (CollectibleCounter.Instance != null)
                CollectibleCounter.Instance.AddCollectible(value);

            Destroy(gameObject);
        }
    }
}

