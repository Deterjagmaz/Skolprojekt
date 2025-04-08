using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class MenuControll : MonoBehaviour
{

    [SerializeField] ClickingScript script;
    [SerializeField] AudioSource MenuClick;

    private void Start()
    {

    }
    
    public void OnButtonClick()
    {
        MenuClick.Play();
        int slimeScore = script.GetScore();
        SceneManager.LoadScene("MenuScene");
    }
}
