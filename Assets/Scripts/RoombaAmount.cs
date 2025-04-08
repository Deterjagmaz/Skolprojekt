using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RoombaAmount : MonoBehaviour
{

    [SerializeField] int CostOfRoomba = 50;
    [SerializeField] private TextMeshProUGUI Pointtext;



    private void Start()
    {
        CostOfRoomba = 50 * (StaticData.roombaAmount + 1);
        Pointtext.text = "Clicks once per upgrade every " + StaticData.loopTime + " seconds. Costs: " + CostOfRoomba + " Slime.";
    }
    public void OnButtonClick()
    {
        if (StaticData.Score >= CostOfRoomba)
        {
            StaticData.Score -= CostOfRoomba;
            StaticData.roombaAmount++;

            CostOfRoomba = 50 * (StaticData.roombaAmount + 1);
            Pointtext.text = "Clicks once per upgrade every " + StaticData.loopTime + " seconds. Costs: " + CostOfRoomba + " Slime.";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
         
    }
}
