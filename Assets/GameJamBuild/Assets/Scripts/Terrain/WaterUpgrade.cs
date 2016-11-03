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
//			upgraded = true;
			Debug.Log ("Tower Placed on Upgrade Tile!");
		}
	}

//	public void TowerUpgradeDamage(){
//		
//		Debug.Log ("TowerUpgrade called");
//
//		if (upgraded == true){
//
//				Debug.Log ("Tower Upgraded!");
//
//			}
//
//			if (tower.tag == "TowerVenus") {
//
//				mouseController.tileTaken.Tower.GetComponent<TowerVenus> ().enemy.TakeDamage (20);
//
//			}
//
//			if (tower.tag == "TowerDandelion") {
//
//				mouseController.tileTaken.Tower.GetComponent<BulletScript> ().target.GetComponent<Enemy>().TakeDamage (10);
//
//			}
		}