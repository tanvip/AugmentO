using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndexScript : MonoBehaviour {
	//private GameObject[] activeObj = new GameObject[] { null, null};
    private GameObject car1;
    private GameObject car2;
    private GameObject butterfly1;
    private GameObject butterfly2;
    private GameObject zombie1;
    private GameObject zombie2;
    private GameObject infoText;
    private GameObject parentImageTarget;
    private GameObject canvas;
    private GameObject car1MethodBtn;
    public const string NewLine="\n";

	// Use this for initialization
	void Start () {
        /*if(InitScript.activeObj[0] == null) {}
        else {
        	Debug.Log("in start");
        	InitScript.activeObj[0].SetActive(true);
        }
        if(InitScript.activeObj[1] == null) {}
        else {
        	InitScript.activeObj[1].SetActive(true);
        }*/
		parentImageTarget = GameObject.Find("ImageTarget");
		//Debug.Log(parentImageTarget.transform.GetChild(8).gameObject.transform.GetChild(0));
		canvas = parentImageTarget.transform.GetChild(8).gameObject;
		car1MethodBtn = canvas.transform.GetChild(6).gameObject;
		car1 = parentImageTarget.transform.GetChild(5).gameObject;
		car2 = parentImageTarget.transform.GetChild(6).gameObject;
		butterfly1 = parentImageTarget.transform.GetChild(3).gameObject;
		butterfly2 = parentImageTarget.transform.GetChild(4).gameObject;
		zombie1 = parentImageTarget.transform.GetChild(1).gameObject;
		zombie2 = parentImageTarget.transform.GetChild(2).gameObject;
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
		Debug.Log("Menu button clicked");
       infoText.GetComponent<TextMesh>().text = "You can now create new objects or " + IndexScript.NewLine + "destroy created objects.";
	}

	public void createObjBtnClick() {
		Debug.Log("Create Object button clicked");
		infoText.GetComponent<TextMesh>().text = "Here are the 3 available predefined classes." + IndexScript.NewLine + 
		                                         "We will create an object of class you select.";
	}

	public void destroyObjBtnClick() {
		Debug.Log("Destroy Object button clicked");
		infoText.GetComponent<TextMesh>().text = "Work in Progress";

	}

	public void carBtnClick() {
		Debug.Log("Create Object > Car button clicked");
        if(InitScript.activeObj[0]==null) {
        	InitScript.activeObj[0] = car1;
        	Debug.Log(InitScript.activeObj[0]);
        	car1MethodBtn.SetActive(true);
       	    car1.SetActive(true);
       	    infoText.GetComponent<TextMesh>().text = "Car car1 = new Car()";
       } else {
       		InitScript.activeObj[1] = car2;
       	  	car2.SetActive(true);
       	  	infoText.GetComponent<TextMesh>().text = "Car car2 = new Car()";
       }
	}

	public void butterflyBtnClick() {
		Debug.Log("Create Object > Butterfly button clicked");
        if(InitScript.activeObj[0]==null) {
        	InitScript.activeObj[0] = butterfly1;
       		butterfly1.SetActive(true);
       		infoText.GetComponent<TextMesh>().text = "Butterfly butterfly1 = new Butterfly()";
       } else {
       		InitScript.activeObj[1] = butterfly2;
       	  	butterfly2.SetActive(true);
       	  	infoText.GetComponent<TextMesh>().text = "Butterfly butterfly2 = new Butterfly()";
       }
	}

	public void zombieBtnClick() {
		Debug.Log("Create Object > Zombie button clicked");
		if(InitScript.activeObj[0]==null) {
			InitScript.activeObj[0] = zombie1;
       		zombie1.SetActive(true);
       		infoText.GetComponent<TextMesh>().text = "Zombie zombie1 = new Zombie()";
       } else {
       		InitScript.activeObj[1] = zombie2;
       	  	zombie2.SetActive(true);
       	  	infoText.GetComponent<TextMesh>().text = "Zombie zombie2 = new Zombie()";
       }
	}

	public void car1MethodControls() {
		
	}

	public void car1Accelerate() {
		Debug.Log("Car1 Methods > Accelerate");
		car1.GetComponent<Animation>().Play();
        car1.GetComponent<Animation>().wrapMode = WrapMode.Loop;
	}

	public void car1Stop() {
		Debug.Log("Car1 Methods > Stop");
		car1.GetComponent<Animation>().Stop();
	}

}
