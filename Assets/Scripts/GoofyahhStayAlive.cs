using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting.Antlr3.Runtime;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEditor.Rendering.CameraUI;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements;

public class GoofyahhStayAlive : MonoBehaviour
{
    private static GoofyahhStayAlive instance;
    void Awake()
    {
       
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
    
    //Stay alive
    
    //Stay alive
    
    //I have never seen the General so despondent
    //I have taken over writing all his correspondence
    //Congress writes, "George, attack the British forces"
    //I shoot back, we have resorted to eating our horses
    //Local merchants deny us equipment, assistance
    //They only take British money, so sing a song of sixpence
    
    //The cavalry's not coming
    
    //But, sir
    
    //Alex, listen
    //There's only one way for us to win this
    //Provoke outrage, outright
    
    //That's right
    
    //Don't engage, strike by night
    //Remain relentless 'til their troops take flight
    
    //Make it impossible to justify the cost of the fight
    
    //Outrun
    
    //Outrun
    
    //Outlast
    
    //Outlast
    
    //Hit 'em quick, get out fast
    
    //Chick-a-plao
    
    //Stay alive 'til this horror show is past
    //We're gonna fly a lot of flags half-mast
    
    //Raise a glass
    
    //I go back to New York and my apprenticeship
    
    //I ask for French aid, I pray that France has sent a ship
    
    //I stay at work with Hamilton
    //We write essays against slavery
    //And every day's a test of our camaraderie
    //And bravery
    
    //We cut supply lines, we steal contraband
    //We pick and choose our battles and places to take a stand
    //And ev'ry day
    //Sir, entrust me with a command
    //And ev'ry day
    
    //No
    
    //He dismisses me out of hand
    
    //Instead of me(stay alive)
    //He promotes
    //Charles Lee
    //Makes him second-in-command
    
    //I'm a General
    //Whee!
    
    //Yeah
    //He's not the choice I would have gone with
    
    //He shits the bed at the Battle of Monmouth
    
    //Ev'ryone attack
    
    //Retreat
    
    //Attack
    
    //Retreat
    
    //What are you doing, Lee?
    //Get back on your feet
    
    //But there's so many of them
    
    //I'm sorry, is this not your speed?
    //Hamilton
    
    //Ready, sir
    //Have Lafayette take the lead
    
    //Yes, sir
    
    //A thousand soldiers die in a hundred degree heat
    
    //As we snatch a stalemate from the jaws of defeat
    
    //Charles Lee was left behind
    //Without a pot to piss in
    //He started sayin' this to anybody who would listen
    
    //Washington cannot be left alone to his devices
    //Indecisive, from crisis to crisis
    //The best thing he can do for the revolution
    //Is turn n' go back to plantin' tobacco in Mount Vernon
    
    //Ooh
    
    //Don't do a thing
    //History will prove him wrong
    
    //But, sir
    
    //We have a war to fight, let's move along
    
    //Strong words from Lee, someone oughta hold him to it
    
    //I can't disobey direct orders

    //Then I'll do it
    //Alexander, you're the closest friend I've got

    //Laurens, do not throw away your shot
}
