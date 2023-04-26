using UnityEngine;

public class CircleJump : MonoBehaviour
{
    public float jumpForce = 10f;  // Stärke des Sprungs
    public float speed = 5f;       // Bewegungsgeschwindigkeit des Kreises
    public Vector2 startPosition = new Vector2(0, 0);  // Startposition des Kreises

    private Rigidbody2D rb;

    void Start()
    {
        // Setze die Startposition des Kreises
        transform.position = startPosition;

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Bewegung des Kreises
        float xMovement = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xMovement, rb.velocity.y);

        // Springen mit Jump Force, wenn die Leertaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(jumpForce);
        }
    }

    // Funktion zum Springen mit einer bestimmten Kraft (Jump Force)
    void Jump(float force)
    {
        rb.velocity = new Vector2(rb.velocity.x, force);
    }

    // Funktion zum Einstellen der Position des Kreises
    public void SetPosition(Vector2 position)
    {
        startPosition = position;
        transform.position = position;
    }

    // Funktion zum Einstellen der Jump Force des Kreises
    public void SetJumpForce(float force)
    {
        jumpForce = force;
    }

    // Funktion zum Einstellen der Geschwindigkeit des Kreises
    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }
}
