using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class matChallenge : MonoBehaviour
{
    private bool isCompleted = false;
    [SerializeField] MeshRenderer indicator;
    [SerializeField] String Answer;


    [SerializeField] TMP_InputField inputField;
    
    public void submit(){
        string inputValue = inputField.text;
        if (inputValue == Answer && isCompleted == false){
            GameObject.Find("GameManager").GetComponent<GameManager>().challengeDone();
            indicator.material.color = Color.green;
            isCompleted = true;

        }else{
            GameObject.FindGameObjectWithTag("bombe").GetComponent<Bomb>().penalty();
        }
    }
}
