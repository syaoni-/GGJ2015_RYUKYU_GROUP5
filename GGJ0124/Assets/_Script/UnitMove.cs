using UnityEngine;
using System.Collections;

public class UnitMove : MonoBehaviour {

	[SerializeField]
	private float gridLength;

	private float moveTime = 1.0f;
	private Vector2 localOrigin;

	private float maxUpDis;
	private float maxDownDis;
	private float maxRightDis;
	private float maxLeftDis;

	private float dx,dy;
	private float offsetPos;

	public enum MOVE_DIRECTION{
		UP,
		DOWN,
		RIGHT,
		LEFT
	}

	// Use this for initialization
	void Start () {
		//gridLength = ?
		gridLength = this.gameObject.transform.parent.GetComponent<UnitMgr> ().mGridLength;

		offsetPos = gridLength / 10;
	}

	public void move(int currentDirection){

		float moveX = 0.0f;
		float moveY = 0.0f;

		do {
			if (currentDirection == Const.DOWN) {
				moveY = gridLength;
				localOrigin.y += gridLength;
			}
			if (currentDirection == Const.UP) {
				moveY = -gridLength;
				localOrigin.y -= gridLength;
			}
			if (currentDirection == Const.LEFT) {
				moveX = gridLength;
				localOrigin.x += gridLength;
			}
			if (currentDirection == Const.RIGHT) {
				moveX = -gridLength;
				localOrigin.x -= gridLength;
			}
		} while(false);

		float minMoveX = -(this.gridLength + this.localOrigin.x - this.transform.position.x + this.offsetPos);
		float maxMoveX = (this.gridLength + this.localOrigin.x - this.transform.position.x - this.offsetPos);
		float minMoveY = -(this.gridLength + this.localOrigin.y - this.transform.position.y + this.offsetPos);
		float maxMoveY = (this.gridLength + this.localOrigin.y - this.transform.position.y - this.offsetPos);

		moveX += Random.Range(minMoveX, maxMoveX);
		moveY += Random.Range(minMoveY, maxMoveY);

		dx = -moveX / moveTime;
		dy = -moveY / moveTime;

		StartCoroutine("moveCorutine");

	}

	private IEnumerator moveCorutine(){

		for (float time = 0.0f; time < moveTime; time += Time.deltaTime) {
			this.transform.Translate(dx * Time.deltaTime, dy * Time.deltaTime, 0);
			Debug.Log("hoge");
			yield return null;
		}

		this.GetComponent<UnitCtrl> ().ActWait ();
	}
}
