using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingAudio : MonoBehaviour {

	public bool isPlaying = false;
	public GvrAudioSource painting;
	public audio

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void playAudio(){
		painting.PlayOneShot;
		isPlaying = true;
	}
}
