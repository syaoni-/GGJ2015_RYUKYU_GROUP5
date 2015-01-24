using UnityEngine;
using System.Collections;

public class InputCtrl : MonoBehaviour {

	public int aUnitNum;
	
	public GameObject mUnitMng;
	public Transform mGridCenter;
	public Transform mGridRightTop;
	public Transform mGridLeftBottom;

	private float mGridLength;

	// Use this for initialization
	void Start () {
		this.mGridLength = CalGridLength ();
		this.InitUnits (aUnitNum);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.UpArrow)) {
			Debug.Log("UpArrow");
			this.UnitMng(Const.UP);
		}
		if (Input.GetKeyUp(KeyCode.DownArrow)) {
			Debug.Log("DownArrow");
			this.UnitMng(Const.DOWN);
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			Debug.Log("LeftArrow");
			this.UnitMng(Const.LEFT);
		}
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			Debug.Log("RightArrow");
			this.UnitMng(Const.RIGHT);
		}
	}

	void UnitMng(int iDirection){
		Transform aUnitMngTrans = this.mUnitMng.transform;
		foreach(Transform child in aUnitMngTrans) {
			child.gameObject.GetComponent<UnitCtrl>().ActUnit(1.0f,iDirection);
		}
	}

	void GetGridDecision(){
	}

	void InitUnits(int iUnitNum){
		// プレハブを取得
		GameObject prefab = (GameObject)Resources.Load ("Prefab/Unit");

		for (int aIndex = 0; aIndex < iUnitNum; aIndex++) {
			// プレハブからインスタンスを生成
			GameObject aGameObject = Instantiate (prefab, CalInitPos(), Quaternion.identity) as GameObject;
			aGameObject.transform.parent = this.mUnitMng.transform;
		}
	}

	private Vector2 CalInitPos(){
		float maxPosX = this.mGridRightTop.position.x;
		float minPosX = this.mGridLeftBottom.position.x;
		float maxPosY = this.mGridRightTop.position.y;
		float minPosY = this.mGridLeftBottom.position.y;

		float oPosX = Random.Range(minPosX,maxPosX);
		Debug.Log ("InitPosX:" + oPosX);
		float oPosY = Random.Range(minPosY,maxPosY);
		Debug.Log ("InitPosY:" + oPosY);
		return new Vector2 (oPosX, oPosY);
	}

	private float CalGridLength(){
		float aGridLength =	this.mGridRightTop.position.x - this.mGridLeftBottom.position.x;
		return aGridLength;
	}

}
