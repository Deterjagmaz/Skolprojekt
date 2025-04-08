using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class MainGameController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Pointtext;
    [SerializeField] AudioSource MenuClick;

    private void Start()
    {
        Pointtext.text = "Slime Harvested: " + StaticData.Score;
    }
    public void OnButtonClick()
    {
        SceneManager.LoadScene("MainGameScene");
        MenuClick.Play();
    }

    private void Update()
    {
        Pointtext.text = "Slime Harvested: " + StaticData.Score;
        //https://www.youtube.com/watch?v=QG5i6DL7-to
    }
}
