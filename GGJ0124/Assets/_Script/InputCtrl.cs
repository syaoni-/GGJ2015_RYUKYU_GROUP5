using UnityEngine;
using System.Collections;

public class InputCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.UpArrow)) {
			Debug.Log("UpArrow");
		}
		if (Input.GetKeyUp(KeyCode.DownArrow)) {
			Debug.Log("DownArrow");
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			Debug.Log("LeftArrow");
		}
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			Debug.Log("RightArrow");
		}
	}

	void UnitManege(){

	}


}
