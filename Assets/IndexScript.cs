using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexScript : MonoBehaviour {
	private GameObject[] activeObj = new GameObject[] { null, null};
    private GameObject car1;
    private GameObject car2;
    private GameObject butterfly1;
    private GameObject butterfly2;
    private GameObject zombie1;
    private GameObject zombie2;
    private GameObject infoText;

	// Use this for initialization
	void Start () {
		car1 = GameObject.Find("car1");
		car2 = GameObject.Find("car2");
		butterfly1 = GameObject.Find("butterfly1");
		butterfly2 = GameObject.Find("butterfly2");
		zombie1 = GameObject.Find("zombie1");
		zombie2 = GameObject.Find("zombie2");
		infoText = GameObject.Find("infoText");
		car1.SetActive(false);
		car2.SetActive(false);
		butterfly1.SetActive(false);
		butterfly2.SetActive(false);
		zombie1.SetActive(false);
		zombie2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

	public void menuBtnClick() {
       infoText.GetComponent<TextMesh>().text = "You can now create new objects or destroy created objects.";
	}

	public void createObjBtnClick() {
		infoText.GetComponent<TextMesh>().text = "Here are the 3 available predefined classes. We will create an object of class you select.";
	}

	public void destroyObjBtnClick() {
		infoText.GetComponent<TextMesh>().text = "Work in Progress";

	}

	public void carBtnClick() {
       if(car1.activeSelf) {
       	  activeObj[1] = car2;
       	  car2.SetActive(true);
       } else {
       	activeObj[0] = car1;
       	car1.SetActive(true);
       }
	}

	public void butterflyBtnClick() {
        if(butterfly1.activeSelf) {
       	  activeObj[1] = butterfly2;
       	  butterfly2.SetActive(true);
       } else {
       	activeObj[0] = butterfly1;
       	butterfly1.SetActive(true);
       }
	}

	public void zombieBtnClick() {
		if(zombie1.activeSelf) {
       	  activeObj[1] = zombie2;
       	  zombie2.SetActive(true);
       } else {
       	activeObj[0] = zombie1;
       	zombie1.SetActive(true);
       }
	}

}
