using UnityEngine;
using System.Collections;

public class UnitCtrl : MonoBehaviour {

	public int aFirstGridNum;

	[SerializeField]
	private string mUnitState;

	[SerializeField]
	private int mCurrentGridNum;
	
	[SerializeField]
	private float mTimeCounter;

	[SerializeField]
	private float mMeetTime = 3.0f;
	[SerializeField]
	private int mDirection;

	[SerializeField]
	private float mMoveSpeed;

	// Use this for initialization
	void Start () {
		this.mTimeCounter = 0f;
		this.InitUnit(aFirstGridNum);
	}
	
	// Update is called once per frame
	void Update () {

		if (this.mUnitState == Const.USER_MEET) {
			if (this.mTimeCounter < this.mMeetTime) {
				this.mTimeCounter += Time.deltaTime;
			}else{
				this.mTimeCounter = 0f;
				this.ActMove();
			}
		}
	}

	private void InitUnit(int iInitGrid){
		this.mUnitState = Const.USER_WAIT;
		this.mCurrentGridNum = iInitGrid;
		this.mTimeCounter = 0f;
	}

	#region ChangeState
	public void ActWait(){
		this.mUnitState = Const.USER_WAIT;
		this.mTimeCounter = 0f;
	}

	public void ActMeet(){
		this.mUnitState = Const.USER_MEET;
		this.mTimeCounter = 0f;
	}

	public void ActMove(){
		this.GetComponent<UnitMove>().move(mDirection);
		this.mUnitState = Const.USER_MOVE;
		this.mTimeCounter = 0f;
		Debug.Log ("move start");
	}
	#endregion
	
	public void ActUnit(float iMeetTime, int iDirection){
		Debug.Log (iDirection);
		if (this.mUnitState == Const.USER_WAIT) {
			this.mMeetTime	= iMeetTime;
			this.mDirection = iDirection;
			this.ActMeet();
		}
	}

	#region KillUnit
	public void Destroy(){
		//DestroyAnimation
		StartCoroutine ("DestroyAnim");
	}
	private IEnumerator DestroyAnim(){
		Destroy (this.gameObject);
		yield return new WaitForSeconds(0.1f);
	}
	#endregion
}