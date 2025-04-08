using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    public GameObject slimemanPrefab; // Reference to the original Slimeman prefab

    void OnMouseDown()
    {
        if (gameObject.name == "Slime Clone")
        {
            // Set a random position for the clone (random X between 1 and 10, Y = 50)
            float randomX = Random.Range(1f, 10f);
            float randomY = 50f; // Fixed height at 50
            Vector3 randomPosition = new Vector3(randomX, randomY, transform.position.z);
            

            // Instantiate the Slimeman clone at the random position
            GameObject clone = Instantiate(slimemanPrefab, randomPosition, Quaternion.identity);
            
            clone.AddComponent<CloneCollision>();
            // Apply a random rotation speed and direction to the clone
            float randomRotationSpeed = Random.Range(30f, 150f); // Random speed between 30 and 150 degrees per second
            clone.AddComponent<RotationControl>().rotationSpeed = randomRotationSpeed;

            // Ensure that the clone has a Rigidbody2D component
            Rigidbody2D rb2D = clone.GetComponent<Rigidbody2D>();
            if (rb2D == null)
            {
                rb2D = clone.AddComponent<Rigidbody2D>(); // Add Rigidbody2D if it's missing
            }

            // Remove all constraints to allow full movement and rotation
            rb2D.constraints = RigidbodyConstraints2D.None;
        }
    }
}

public class CloneCollision : MonoBehaviour
{
    // Detect collision with the "Death Plane"
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death Plane"))
        {
            // Destroy the clone when it hits the Death Plane
            Destroy(gameObject);
        }
    }
}

    public class RotationControl : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        // Apply 2D rotation to the clone around the Z-axis at the specified speed
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }


}


