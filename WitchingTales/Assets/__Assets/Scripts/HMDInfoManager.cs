using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset Plugged");
        }
        else if(XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "MockHMD Display" || XRSettings.loadedDeviceName == "Mock HMD"))
        {
            Debug.Log("Using Mock HMD");
        }
        else
        {
            Debug.Log("We have a headset: " + XRSettings.loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
