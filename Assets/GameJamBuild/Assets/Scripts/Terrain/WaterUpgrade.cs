using UnityEngine;
using System.Collections;

public class WaterUpgrade : MonoBehaviour {

	public GameObject tower;
	public GameObject tile;
	public GameObject gameManager;

	public bool upgraded;

	private MouseController mouseController;



	void Start () {

		mouseController = gameManager.GetComponent<MouseController> ();
		upgraded = false;
	}
	
	 
	public void Update () {
		
		if (tile.GetComponent<TileTaken> ().isTaken == true) {

			tower = mouseController.tileTaken.Tower;
			upgraded = true;
			Debug.Log ("Tower Placed on Upgrade Tile!");
		}
	}
}