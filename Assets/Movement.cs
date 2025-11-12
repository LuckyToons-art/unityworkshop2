using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 7f; // Movement speed in units per second

    private Rigidbody2D rb;
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;  // No gravity in top-down games
        rb.freezeRotation = true; // Prevent unwanted rotation
    }

    private void Update()
    {
        // Get raw input (-1, 0, or 1) for both axes
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
        float moveY = Input.GetAxisRaw("Vertical");   // W/S or Up/Down

        // Combine into a Vector2 and normalize to avoid faster diagonal movement
        moveInput = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        // Move the player by setting the Rigidbody2D velocity
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
