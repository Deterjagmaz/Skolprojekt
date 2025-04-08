using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VaccumScript : MonoBehaviour
{
    [SerializeField] int costOfVaccum = 10;
    [SerializeField] private TextMeshProUGUI Pointtext;
    void Start()
    {
        if (StaticData.clickingPower > 1)
        {
            costOfVaccum = (10 * StaticData.clickingPower - 10) + (5 * StaticData.clickingPower - 5);
        }
        Pointtext.text = "Upgrade your click with one. Costs: " + costOfVaccum + " Slime.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        if (StaticData.Score >= costOfVaccum)
        {
            StaticData.Score -= costOfVaccum;
            StaticData.clickingPower ++;

            if (StaticData.clickingPower > 1)
            {
                costOfVaccum = (10 * StaticData.clickingPower - 10) + (5 * StaticData.clickingPower - 5);
            }
            Pointtext.text = "Upgrade your click with one. Costs: " + costOfVaccum + " Slime.";
        }
    }
}
