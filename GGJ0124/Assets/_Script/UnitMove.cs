using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	private float gridLength;

	private float moveTime;

	private float maxUpDis;
	private float maxDownDis;
	private float maxRightDis;
	private float maxLeftDis;

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

		//moveX = 
		//moveY = 

		switch (currentDirection) {
			case MOVE_DIRECTION.UP:
				moveY = gridLength;
				break;
			case MOVE_DIRECTION.DOWN:
				moveY = -gridLength;
				break;
			case MOVE_DIRECTION.RIGHT:
				moveX = gridLength;
				break;
			case MOVE_DIRECTION.LEFT:
				moveX = -gridLength; 
				break;
		}


	}

	private IEnumerator moveCorutine(){
		for (float time = 0.0f; time < moveTime;)

		yield return null;
	}
}
