using UnityEngine;
using System.Collections;

public class UnitCtrl : MonoBehaviour {
	public string mUnitState;

	public int aFirstGridNum;

	[SerializeField]
	private Vector2 mDirection;

	[SerializeField]
	private float mTimeCounter;
	[SerializeField]
	private float mMoveSpeed;

	[SerializeField]
	private float mMoveTime = 3.0f;
	[SerializeField]
	private float mMeetTime = 3.0f;

	// Use this for initialization
	void Start () {
		this.InitUnit(aFirstGridNum);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.mUnitState == Const.USER_MEET) {
			if (this.mTimeCounter < this.mMeetTime) {
				this.mTimeCounter += Time.deltaTime;
			}else{
				this.mTimeCounter = 0f;
//				this.GetComponent<UnitMove>.move(this.mDirection);
			}
		}
	}

	public void InitUnit(int iInitGrid){
		this.mUnitState = Const.USER_WAIT;
		this.mTimeCounter = 0f;
	}


	#region ChangeState
	public void ActWait(int iGridNum){
		this.mUnitState = Const.USER_WAIT;
	}

	public void ActMeet(int iGridNum){
		this.mUnitState = Const.USER_MEET;
	}
	
	public void ActMove(int iGridNum){
		this.mUnitState = Const.USER_MOVE;
	}
	#endregion


	public void ActUnit(string iDirection){
		Debug.Log (iDirection);
		if (this.mUnitState == Const.USER_WAIT) {

			this.ActMeet(0);
		}
	}

	public void Destroy(){
		//DestroyAnimation
		StartCoroutine ("DestroyAnim");
	}

	private IEnumerator DestroyAnim(){
		Destroy (this.gameObject);
		yield return new WaitForSeconds(0.1f);
	}
}