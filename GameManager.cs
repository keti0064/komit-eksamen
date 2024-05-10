using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Runtime.InteropServices;

public class GameManager: MonoBehaviour
{
    int challengesFinished = 0;
    int challengeCount;

    private void Start(){
        challengeCount = GameObject.FindGameObjectsWithTag("challengeTrigger").Length;
        Debug.Log("Challenge count: "+challengeCount);
    }

    [SerializeField] Bomb bomb;
    public void challengeDone(){
        Debug.Log("Challenge complete");
        challengesFinished ++;

        if (challengesFinished == challengeCount){
            bomb.isDone = true;
            bomb.isLive = false;
            Debug.Log("bomb defused");
        }

    }



    private void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){Application.Quit();}
    }

}
