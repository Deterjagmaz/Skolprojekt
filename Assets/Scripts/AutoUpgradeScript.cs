using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoUpgradeScript : MonoBehaviour
{
    private static AutoUpgradeScript instance;
    [SerializeField] GameObject slimeClone;// Static reference to the single instance
    [SerializeField] AudioSource BGM;

    void Awake()
    {
        BGM.Play();
        // If there's no instance of AutoUpgradeScript, make this object the instance
        if (instance == null)
        {
            instance = this;  // Set this object as the single instance
            DontDestroyOnLoad(gameObject);  // Ensure this object isn't destroyed when loading a new scene
        }
        else
        {
            // If an instance already exists, destroy this duplicate object
            Destroy(gameObject);
        }
    }

    void Start()
    {
        StartCoroutine(UpgradeLoop());
    }

    IEnumerator UpgradeLoop()
    {
        while (true)
        {
            StaticData.autoUpgrades = StaticData.roombaAmount; // add others when u make them...
            StaticData.Score += StaticData.autoUpgrades;
            if (StaticData.roombaAmount > 0 && SceneManager.GetActiveScene().name == "MainGameScene")
            {
                
            }

            yield return new WaitForSeconds(StaticData.loopTime);
        }
    }

    
}