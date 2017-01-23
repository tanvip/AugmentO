using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class EventScript : MonoBehaviour, IVirtualButtonEventHandler {
    private GameObject runButton;
    private GameObject stopButton;
    private GameObject car;
	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }
        runButton = transform.FindChild ("runbtn").gameObject;
        stopButton = transform.FindChild ("stopbtn").gameObject;
        car = GameObject.Find("car");
	}

	 /// Called when the virtual button has just been released:
    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        /*mapCube.SetActive(false);
        temperatureCube.SetActive(false);
        timeText.SetActive(true);
        weatherText.SetActive(false);
        wallpaper1.SetActive(false);
        timeCube.SetActive(true);*/
        Debug.Log("Button released!");
    }

     /// Called when the virtual button has just been pressed:
    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
    	Debug.Log(vb.VirtualButtonName + "===============");
        switch (vb.VirtualButtonName)
        {
            case "runbtn":
             
                car.GetComponent<Animation>().Play();
                car.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            Debug.Log("YAY!!!!!!!");
            break;

            case "stopbtn":
            Debug.Log("STOPPP");
               car.GetComponent<Animation>().Stop();
            break;

            default:
                throw new UnityException("Button not supported: " + vb.VirtualButtonName);
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
