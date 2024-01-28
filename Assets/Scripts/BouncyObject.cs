using UnityEngine;

public class BouncyObject : MonoBehaviour
{
    // Adjust this value to control the bounciness
    public float bounceForce = 11111111110;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the rectangle
        if (collision.gameObject.CompareTag("Player"))
        {
            // Calculate the bounce direction
            Vector2 bounceDirection = (collision.contacts[0].point - (Vector2)transform.position).normalized;

            // Apply the bounce force to the rigidbody
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(bounceDirection * bounceForce, ForceMode2D.Impulse);
            Debug.Log(bounceDirection);
        }
    }
}
