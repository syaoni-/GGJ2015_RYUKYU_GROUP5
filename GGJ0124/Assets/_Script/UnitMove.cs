using UnityEngine;
using System.Collections;

public class UnitMove : MonoBehaviour {

	private float gridLength;

	private float moveTime;
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
		offsetPos = gridLength / 10;
	}

	public void move(int currentDirection){

		float moveX = 0.0f;
		float moveY = 0.0f;

		switch (currentDirection) {
			case 0:
				moveY = gridLength;
				localOrigin.y += gridLength;
				break;
			case 1:
				moveY = -gridLength;
				localOrigin.y -= gridLength;
				break;
			case 2:
				moveX = gridLength;
				localOrigin.x += gridLength;
				break;
			case 3:
				moveX = -gridLength;
				localOrigin.x -= gridLength;
				break;
		}

		float minMoveX = -this.gridLength + this.localOrigin.x - this.transform.position.x + this.offsetPos;
		float maxMoveX = this.gridLength + this.localOrigin.x - this.transform.position.x - this.offsetPos;
		float minMoveY = -this.gridLength + this.localOrigin.y - this.transform.position.y + this.offsetPos;
		float maxMoveY = this.gridLength + this.localOrigin.y - this.transform.position.y - this.offsetPos;

		moveX += Random.Range(minMoveX, maxMoveX);
		moveY += Random.Range(minMoveY, maxMoveY);

		dx = -moveX / moveTime;
		dy = -moveY / moveTime;

		StartCoroutine("moveCorutine");

	}

	private IEnumerator moveCorutine(){

		for (float time = 0.0f; time < moveTime;time += Time.deltaTime) {
			this.transform.Translate(dx, dy, 0);
			yield return null;
		}

	}
}
