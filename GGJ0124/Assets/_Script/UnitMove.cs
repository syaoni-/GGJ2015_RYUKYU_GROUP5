using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private float gridLength;

	private float moveTime;
	private Vector2 localOrigin;

	private float maxUpDis;
	private float maxDownDis;
	private float maxRightDis;
	private float maxLeftDis;

	private float dx,dy;

	public enum MOVE_DIRECTION{
		UP,
		DOWN,
		RIGHT,
		LEFT
	}

	// Use this for initialization
	void Start () {

	}

	void move(MOVE_DIRECTION currentDirection){

		float moveX;
		float moveY;

		switch (currentDirection) {
			case MOVE_DIRECTION.UP:
				moveY = gridLength;
				localOrigin.y += gridLength;
				break;
			case MOVE_DIRECTION.DOWN:
				moveY = -gridLength;
				localOrigin.y -= gridLength;
				break;
			case MOVE_DIRECTION.RIGHT:
				moveX = gridLength;
				localOrigin.x += gridLength;
				break;
			case MOVE_DIRECTION.LEFT:
				moveX = -gridLength;
				localOrigin -= gridLength;
				break;
		}

		float minMoveX = -gridLength + (localOrigin - this.transform.position.x );
		float maxMoveX = gridLength + (localOrigin - this.transform.position.x);
		float minMoveY = -gridLength + (localOrigin - this.transform.position.y);
		float maxMoveY = gridLength + (localOrigin - this.transform.position.y);

		moveX += Random.Range(minMoveX, maxMoveX);
		moveY += Random.Range (minMoveY, maxMoveY);

		dx = -moveX / moveTime;
		dy = -moveY / moveTime;

		StartCoroutine("moveCorutine");

	}

	private IEnumerator moveCorutine(){

		for (float time = 0.0f; time < moveTime;time += Time.deltaTime) {
			this.transform.position.x += dx;
			this.transform.position.y += dy;
			yield return null;
		} 

	}
}
