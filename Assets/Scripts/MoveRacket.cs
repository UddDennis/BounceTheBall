using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    // Adjust this speed to control the movement speed
    public float moveSpeed = 5f;

    void Update()
    {
        // Get the current mouse position
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Ensure the z-coordinate is 0 for 2D

        // Move the rectangle towards the mouse position
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}