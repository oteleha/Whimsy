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

		if (tile.GetComponent<TileTaken> ().isTaken == true) {

			if (tower.tag == "TowerPoison") {

				tower.GetComponent<TowerPoison> ().enemy.TakeDamage (25);

			}

			if (tower.tag == "TowerVenus") {

				tower.GetComponent<TowerVenus> ().enemy.TakeDamage (20);

			}

			if (tower.tag == "TowerDandelion") {

				tower.GetComponent<BulletScript> ().target.GetComponent<Enemy>().TakeDamage(5);

			}
		} 
	}
}
