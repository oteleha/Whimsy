using UnityEngine;
using System.Collections;

public class WaterUpgrade : MonoBehaviour {

	public GameObject tower;
	public GameObject tile;
	public GameObject gameManager;
	private TileTaken tileTaken;
	private MouseController mouseController;


	void Start () {

//		tile = gameManager.GetComponent<MouseController> ().tile;
//		tower = tile.GetComponent<MouseController> ().GetComponent<TileTaken>().Tower;
		tileTaken = tile.GetComponent<TileTaken> ();
		mouseController = gameManager.GetComponent<MouseController> ();	

	}
	
	 
	void Update () {
		
		tower = gameManager.GetComponent<TileTaken>().Tower;

		if (tile.GetComponent<TileTaken> ().isTaken == true) {

//			tower = gameManager.GetComponent<TileTaken>().Tower.gameObject;

			Debug.Log ("isTaken is true");

			if (this.tower.tag == "TowerPoison") {
				
				//tower = gameManager.GetComponent<TileTaken>().Tower.gameObject;
				tower = mouseController.tileTaken.Tower as GameObject;

			mouseController.tileTaken.Tower.GetComponent<TowerPoison> ().enemy.TakeDamage (20);
			Debug.Log ("Tower Upgraded!");

			}

			if (tower.tag == "TowerVenus") {
				Debug.Log ("Tower Upgraded!");
				tower.GetComponent<TowerVenus> ().enemy.TakeDamage (20);

			}

			if (tower.tag == "TowerDandelion") {
				Debug.Log ("Tower Upgraded!");
				tower.GetComponent<BulletScript> ().target.GetComponent<Enemy> ().TakeDamage (10);

				}
			}
		}
	}

//	public void TowerUpgrade(){
//		
//		Debug.Log ("Tower Upgrade Called");
//
////		if(tile.GetComponent<TileTaken>().isTaken == true){
////
//
//		if (tower.tag == "TowerPoison") {
//
//			mouseController.tileTaken.Tower.GetComponent<TowerPoison> ().enemy.TakeDamage (15);
//				Debug.Log ("Tower Upgraded!");
//
//		}
//
//		if (tower.tag == "TowerVenus") {
//
//			mouseController.tileTaken.Tower.GetComponent<TowerVenus> ().enemy.TakeDamage (20);
//
//		}
//
//		if (tower.tag == "TowerDandelion") {
//
//			mouseController.tileTaken.Tower.GetComponent<BulletScript> ().target.GetComponent<Enemy>().TakeDamage (10);
//
//			}
//
//		}
