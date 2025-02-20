using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMD_Manager : MonoBehaviour{
    [SerializeField] GameObject xrPlayer;
    [SerializeField] GameObject fpsPlayer;

    void Start(){
        Debug.Log("HMD: " + XRSettings.loadedDeviceName);
        if (XRSettings.isDeviceActive/* || XRSettings.loadedDeviceName == */){
            fpsPlayer.SetActive(false);
            xrPlayer.SetActive(true);

        } else {
            Debug.Log("No HMD Detected, using FPS player");
            fpsPlayer.SetActive(true);
            xrPlayer.SetActive(false);
            

        }
        
    }

    void Update(){
        
    }
}