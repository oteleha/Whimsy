
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseController : MonoBehaviour {
	

	public int Selected;//holds int that will determine what the variable will be determined by other scripts
	public GameObject[] towers; // array that holds the types of towers that can be put down
	public int[] prices;//the price that you must pay in money to place the tower
	public GameObject tile;//the placeholder where the tower can be placed
	public int currentSeedCount;//updates how many seeds the player can spend after a tower has been placed
	public Transform manager;//reference to the manager script
	public AudioClip[] clips;
	public Camera mainCamera;
	public AudioSource source;
	public GameObject[] mushTowers;
	public int mushIndex;

	private AudioClip levelMusic;
	private Money money;//reference to money script
	private TileTaken tileTaken;//calls the script attached to each tile and determines whether there is a tower already placed there

	void Start(){

		tileTaken = GetComponent<TileTaken> ();
		money = GetComponent<Money> ();
		money.SetSeedText ();
		Selected = 0;
		source = GetComponent<AudioSource> ();

	}

	void Update(){

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 1000)) {
			
			tile = hit.collider.gameObject;
			Debug.Log ("Hit Tile");
		} 

		else {
			
			tile = null;
		}

		if (Input.GetMouseButtonDown (0) && tile != null) {


			if ((tile.GetComponent<TileTaken>().isTaken == false) && manager.GetComponent<Money>().money > prices[Selected])
			{			
		
					currentSeedCount = money.money -= prices [Selected];
					money.SetSeedText ();
					Debug.Log (money.money);
					Vector3 pos = new Vector3 (tile.transform.position.x, .5f, tile.transform.position.z);

				if (Selected == 1) {
					Debug.Log ("index == 1");

					mushIndex = Random.Range (0, mushTowers.Length);
					tileTaken.Tower = (GameObject)Instantiate (mushTowers [mushIndex], pos, Quaternion.Euler (90, 0, 0));
				} 

				else 
				{
					
					tileTaken.Tower = (GameObject)Instantiate (towers [Selected], pos, Quaternion.Euler(90,0,0));
				}
					
					tile.GetComponent<TileTaken>().isTaken = true;
					source.clip = clips[Selected];
					source.Play ();
			}
		}
	}
}