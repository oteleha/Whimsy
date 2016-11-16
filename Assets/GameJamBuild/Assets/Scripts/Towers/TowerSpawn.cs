using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TowerSpawn : MonoBehaviour {
	
	public int mushIndex;
	public int index;//indicates which index number the tower has been assigned Element 0,1, or 2

	public TowerPoison randomTower;

	public GameObject spawnTower;//reference to the mousecontroller script
	public GameObject temp;
	public GameObject tile;

	void Start(){

		//mushTower = randomTower.GetComponent<TowerPoison> ().temp;
		//mushIndex = Random.Range(0, randomTower.towerTypes.Length);
	}

	public void OnClick(){
		
		spawnTower.GetComponent<MouseController>().Selected = index;
	
	}

	void Update(){

		tile = spawnTower.GetComponent<MouseController> ().tile;

	}
}