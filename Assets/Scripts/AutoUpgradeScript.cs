using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoUpgradeScript : MonoBehaviour
{
    private static AutoUpgradeScript instance;
    [SerializeField] GameObject slimeClone;
    [SerializeField] AudioSource BGM;

    void Awake()
    {
        BGM.Play();
        
        if (instance == null)
        {
            instance = this;  
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
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