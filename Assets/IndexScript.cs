using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndexScript : MonoBehaviour {
	//private GameObject[] activeObj = new GameObject[] { null, null};
    static private GameObject car1;
    private GameObject car2;
    private GameObject butterfly1;
    private GameObject butterfly2;
    private GameObject zombie1;
    private GameObject zombie2;
    private GameObject parentImageTarget;
    private GameObject canvas;
    private GameObject car1MethodBtn;
    public const string NewLine="\n";

	// Use this for initialization
	void Start () {
		Debug.Log("in start");
		parentImageTarget = GameObject.Find("ImageTarget");
		//Debug.Log(parentImageTarget.transform.GetChild(8).gameObject.transform.GetChild(0));
		canvas = parentImageTarget.transform.Find("Canvas").gameObject;
		car1 = parentImageTarget.transform.Find("car1").gameObject;
		car2 = parentImageTarget.transform.Find("car2").gameObject;
		butterfly1 = parentImageTarget.transform.Find("butterfly1").gameObject;
		butterfly2 = parentImageTarget.transform.Find("butterfly2").gameObject;
		zombie1 = parentImageTarget.transform.Find("zombie1").gameObject;
		zombie2 = parentImageTarget.transform.Find("zombie2").gameObject;
		GameObject infoPanel = canvas.transform.Find("infoPanel").gameObject;
		InitScript.infoText = infoPanel.transform.Find("infoText").GetComponent<Text>();
		Debug.Log(InitScript.infoText);
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
       InitScript.infoText.text = "You can now create new objects or " + IndexScript.NewLine + "destroy created objects.";
	}

	public void createObjBtnClick() {
		Debug.Log("Create Object button clicked");
		InitScript.infoText.text = "Here are the 3 available predefined classes." + IndexScript.NewLine + 
		                                         "We will create an object of class you select.";
	}

	public void destroyObjBtnClick() {
		Debug.Log("Destroy Object button clicked");
		InitScript.infoText.text = "Work in Progress";

	}

	public void carBtnClick() {
		Debug.Log("Create Object > Car button clicked");
        if(InitScript.activeObj[0]==null) {
        	InitScript.activeObj[0] = car1;
        	Debug.Log(InitScript.activeObj[0]);
        	car1MethodBtn.SetActive(true);
       	    car1.SetActive(true);
       	    InitScript.infoText.text = "Car car1 = new Car()";
       } else {
       		InitScript.activeObj[1] = car2;
       	  	car2.SetActive(true);
       	  	InitScript.infoText.text = "Car car2 = new Car()";
       }
	}

	public void butterflyBtnClick() {
		Debug.Log("Create Object > Butterfly button clicked");
        if(InitScript.activeObj[0]==null) {
        	InitScript.activeObj[0] = butterfly1;
       		butterfly1.SetActive(true);
       		InitScript.infoText.text = "Butterfly butterfly1 = new Butterfly()";
       } else {
       		InitScript.activeObj[1] = butterfly2;
       	  	butterfly2.SetActive(true);
       	  	InitScript.infoText.text = "Butterfly butterfly2 = new Butterfly()";
       }
	}

	public void zombieBtnClick() {
		Debug.Log("Create Object > Zombie button clicked");
		if(InitScript.activeObj[0]==null) {
			InitScript.activeObj[0] = zombie1;
       		zombie1.SetActive(true);
       		InitScript.infoText.text = "Zombie zombie1 = new Zombie()";
       } else {
       		InitScript.activeObj[1] = zombie2;
       	  	zombie2.SetActive(true);
       	  	InitScript.infoText.text = "Zombie zombie2 = new Zombie()";
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

	public void tuts1InitEvent() {
		Debug.Log("Tuts1 selected");
		car1.SetActive(true);
	}

	public void exeInitEvent() {
		Debug.Log("Main > Exercise");
		InitScript.infoText.text = "We have some exercises designed for you." + IndexScript.NewLine + 
                                  "You may take them one by one";
	}

	public void exe1InitEvent() {
		Debug.Log("Exercise > Exercise 1");
		InitScript.infoText.text = "In this exercise you have to drive the car!" + IndexScript.NewLine + 
                                  "Simple? Yeah. Move it forward and take a turn" + IndexScript.NewLine + 
                                  "You are given following two methods to finish the task. Good Luck!";
	}


	public void exe1Action1Event() {
		Debug.Log("Exercise > Exercise 1 > Action 1(Accelerate)");
        car1.GetComponent<Animation>().Play("carMoveStraight");
        InitScript.infoText.text = "You moved the car with Accelerate() method";
	}

	public void exe1Action2Event() {
		Debug.Log("Exercise > Exercise 1 > Action 2(Rotate)");
        car1.GetComponent<Animation>().Play("carRotationClockWise");
        InitScript.infoText.text = "You roatated the car by 90 degrees with Rotate(90) method";
	}

}
