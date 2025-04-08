using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScript : MonoBehaviour
{
    public GameObject slimemanPrefab; 

    void OnMouseDown()
    {
        if (gameObject.name == "Slime Clone")
        {
            
            float randomX = Random.Range(1f, 10f);
            float randomY = 50f; 
            Vector3 randomPosition = new Vector3(randomX, randomY, transform.position.z);
            

            
            GameObject clone = Instantiate(slimemanPrefab, randomPosition, Quaternion.identity);
            
            clone.AddComponent<CloneCollision>();
            
            float randomRotationSpeed = Random.Range(30f, 150f); 
            clone.AddComponent<RotationControl>().rotationSpeed = randomRotationSpeed;

            
            Rigidbody2D rb2D = clone.GetComponent<Rigidbody2D>();
            if (rb2D == null)
            {
                rb2D = clone.AddComponent<Rigidbody2D>(); 
            }

            
            rb2D.constraints = RigidbodyConstraints2D.None;
        }
    }
}

public class CloneCollision : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death Plane"))
        {
            
            Destroy(gameObject);
        }
    }
}

    public class RotationControl : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
       
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }


}


