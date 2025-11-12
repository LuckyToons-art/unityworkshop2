using UnityEngine;

public class BobbingIdle : MonoBehaviour
{
    [Header("Bobbing Settings")]
    [Tooltip("How far the object moves up and down")]
    public float amplitude = 0.25f;
    
    [Tooltip("How fast the object moves up and down")]
    public float frequency = 1f;

    private Vector3 startPos;

    void Start()
    {
        // Store the starting position
        startPos = transform.localPosition;
    }

    void Update()
    {
        // Calculate new Y position
        float newY = startPos.y + Mathf.Sin(Time.time * frequency * Mathf.PI * 2) * amplitude;
        
        // Apply the position
        transform.localPosition = new Vector3(startPos.x, newY, startPos.z);
    }
}
