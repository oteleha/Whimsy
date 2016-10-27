﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TowerSpawn : MonoBehaviour {

	public int Index;//indicates which index number the tower has been assigned Element 0,1, or 2
	public GameObject spawnTower;//reference to the mousecontroller script
	//public GameObject mushTower;
	public TowerPoison randomTower;
	public int mushIndex;
	public GameObject temp;

	void Start(){

		//mushTower = randomTower.GetComponent<TowerPoison> ().temp;
		//mushIndex = Random.Range(0, randomTower.towerTypes.Length);
	}

	public void OnClick(){
		
		spawnTower.GetComponent<MouseController>().Selected = Index;
	
	}
}