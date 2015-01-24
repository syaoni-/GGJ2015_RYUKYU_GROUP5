using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {

	public ArrayList grids = new ArrayList();
	public Transform  aUpperRightPos;

	// Use this for initialization
	void Start () {

		GridCtrl firstGrid = new GridCtrl();
		firstGrid.originPos = aUpperRightPos.position;
		grids.Add(firstGrid);

		Vector2 setPos;
		float setX = aUpperRightPos.position.x;
		float setY = aUpperRightPos.position.y;

		for (int i=1; i < Const.COL * Const.ROW; i++) {

			setX += Const.GRID_LENGTH;
			if (i % Const.ROW == 0) {
				setX = aUpperRightPos.position.x;
				setY += Const.GRID_LENGTH;
			}

			GridCtrl newGrid = new GridCtrl();
			newGrid.originPos = new Vector2(setX, setY);
			grids.Add(newGrid);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
