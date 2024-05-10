using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class challTrigger : MonoBehaviour
{
    private bool isInRange;

    public GameObject challPanel;

    private void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag=="Player"){
            isInRange = true;
        }
    }

    private void OnTriggerExit(Collider collider){
        if(collider.gameObject.tag=="Player"){
            isInRange = false;
        }
    }

    private void Update(){
        if (isInRange){
            challPanel.SetActive(true);
        }else{
            challPanel.SetActive(false);
        }
    }
    

   
}
