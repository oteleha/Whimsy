using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	public AudioSource source;
	public AudioClip levelMusic;

	// Use this for initialization
	void Start () {

		source = GetComponent<AudioSource> ();
		source.clip = levelMusic;
		source.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
