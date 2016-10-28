using UnityEngine;
using System.Collections;

public class WaterUpgrade : MonoBehaviour {

	public GameObject tower;
	public GameObject tile;
	private TileTaken tileTaken;


	void Start () {

		tile = GetComponent<MouseController> ().tile;
		tower = tile.GetComponent<TileTaken> ().Tower;
		//tileTaken = GetComponent<TileTaken> ();
	
	}
	
	 
	void Update () {

		if (tile.GetComponent<TileTaken> ().isTaken == true && tower.tag =="TowerPoison") {
			Debug.Log ("isTaken is true");
//			if (tower.tag == "TowerPoison") {
				Debug.Log ("Tower Upgraded!");
			tower.GetComponent<TowerPoison> ().enemy.TakeDamage (25);
//
//			}
//
//			if (tower.tag == "TowerVenus") {
//				Debug.Log ("Tower Upgraded!");
//				tower.GetComponent<TowerVenus> ().enemy.TakeDamage (20);
//
//			}
//
//			if (tower.tag == "TowerDandelion") {
//				Debug.Log ("Tower Upgraded!");
//				tower.GetComponent<BulletScript> ().target.GetComponent<Enemy> ().TakeDamage (10);
//
//			}
//		}
		}
	}
}