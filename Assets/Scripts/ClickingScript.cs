using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickingScript : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI Pointtext;
    public GameObject slimeClonePrefab;


    public void Start()
    {
        Pointtext.text = "Slime Harvested: " + StaticData.Score;
    }

    public int GetScore()
    {
        return StaticData.Score;
    }
    public void DecreaseScore(int amount)
    {
        StaticData.Score -= amount;  // Subtract the amount from Score
    }


    // Update is called once per frame
    void Update()
    {
        // Check if the user clicks on the sprite
        if (Input.GetMouseButtonDown(0)) // 0 is left mouse button
        {

            // Raycast to check if the click is over this sprite
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);


            if (hit.collider != null && hit.collider.gameObject.CompareTag("MainObject"))
            {
                // Increment the count
                StaticData.Score += StaticData.clickingPower;
                Pointtext.text = "Slime Harvested: " + StaticData.Score;
                SpawnClone();
            }
        }
        Pointtext.text = "Slime Harvested: " + StaticData.Score;


    }

        void SpawnClone()
        {
        float randomX = Random.Range(-10f, 10f);
        Vector3 spawnPosition = new Vector3(randomX, 10f, 0f);


        // Instantiate the slime clone prefab at the clicked position
        GameObject clone = Instantiate(slimeClonePrefab, spawnPosition, Quaternion.identity);
        float randomRotationSpeed = Random.Range(60f, 300f);
        clone.AddComponent<RotationControl>().rotationSpeed = randomRotationSpeed;
        Rigidbody2D rb2D = clone.GetComponent<Rigidbody2D>();
        float randomSize = Random.Range(0.25f, 1.5f);  // Random size between 0.25 and 2
        clone.transform.localScale = new Vector3(randomSize, randomSize, 1f);

        if (rb2D == null)
        {
            rb2D = clone.AddComponent<Rigidbody2D>(); // Add Rigidbody2D if it's missing
        }

        rb2D.constraints = RigidbodyConstraints2D.None;

        clone.AddComponent<CloneDeath>();

    }

    }
