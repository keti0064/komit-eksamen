using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Bomb : MonoBehaviour
{
    public float timer = 10;
    public TMP_Text timerText;
    public TMP_Text uiTimerText;
    public bool isLive= true;

    public bool isDone;


    private void Update(){
        if (isLive){
            timer -= 1*Time.deltaTime;
            timerText.text = Math.Round(timer).ToString();
            uiTimerText.text = Math.Round(timer).ToString();
        }else{
            timerText.text = ":)";
            GetComponent<MeshRenderer>().material.color = Color.green;
            uiTimerText.color= Color.green;
            uiTimerText.text = "bomben er DEMONTERET!";
        }

        if (timer <= 0 && isDone != true){ isLive = false; timerText.text = "KACHAOWOWOW"; uiTimerText.text = "bomben er EKSPLODERET!";}
    }

    public void penalty(){
        uiTimerText.color = Color.red;
        Invoke("resetColor", 0.6f);
        timer -=10;
    }

    private void resetColor(){
        uiTimerText.color = Color.white;

    }

}
