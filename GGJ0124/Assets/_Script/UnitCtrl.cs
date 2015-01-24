using UnityEngine;
using System.Collections;

public class UnitCtrl : MonoBehaviour {
//	public string mUnitState;
//
//	public int aFirstGridNum;
//
//	[SerializeField]
//	private float mTimeCounter;
//	[SerializeField]
//	private float mMoveSpeed;
//
//	[SerializeField]
//	private float mMoveTime;
//	[SerializeField]
//	private float mMeetTime;
//
//	// Use this for initialization
//	void Start () {
//		this.InitUnit(aFirstGridNum);
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (this.mUnitState == Const.USER_MEET) {
//			if (this.mTimeCounter < this.mMeetTime) {
//				this.mTimeCounter += Time.deltaTime;
//			}else{
//				this.mTimeCounter = 0f;
//			}
//		}
//
//		if (this.mUnitState == Const.USER_MOVE) {
//			//Test Movement
//			if (this.mTimeCounter < this.mMoveTime) {
//				this.mTimeCounter += Time.deltaTime;
//				Transform aTrans = this.GetComponent<GameObject>().gameObject.transform;
//				aTrans.Translate(Vector3.right * Time.deltaTime * mMoveSpeed);
//			}else{
//				this.ActWait();
//				this.mTimeCounter = 0f;
//			}
//		}
//	}
//
//	public void InitUnit(int iInitGrid){
//		this.mUnitState = Const.USER_WAIT;
//		this.mTimeCounter = 0f;
//	}
//
//	public void ActWait(int iGridNum){
//		this.mUnitState = Const.USER_WAIT;
//	}
//
//	public void ActMeet(int iGridNum, float iMeetTime){
//		this.mUnitState = Const.USER_MEET;
//		this.mMeetTime = iMeetTime;
//	}
//	
//	public void ActMove(int iGridNum, float iMoveTime){
//		this.mUnitState = Const.USER_MOVE;
//		this.mMoveTime = iMoveTime;
//	}
//
//	public void ActUnit(){
//		if (this.mUnitState == Const.USER_WAIT) {
//			//Action
//		}
//	}
//
}
