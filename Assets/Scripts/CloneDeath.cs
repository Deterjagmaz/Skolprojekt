using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneDeath : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death Plane"))
        {
            // Destroy the clone when it hits the Death Plane
            Destroy(gameObject);
        }
    }
}
