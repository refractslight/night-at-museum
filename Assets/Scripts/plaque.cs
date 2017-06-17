using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque : MonoBehaviour {

	public GameObject panel;
	public GameObject dismissButton;
	public GameObject learnMore;
	public AudioClip paintingAudio;
	public AudioSource panelBackground;
	void Start() {
		panelBackground = GetComponent<AudioSource> ();
	}


	public void togglePanel (GameObject panel){
		panel.SetActive (!panel.activeSelf);
		dismissButton.SetActive (!dismissButton.activeSelf);
		learnMore.SetActive (!learnMore.activeSelf);

	}

	/*public void playAudio() {
		panelBackground.PlayOneShot (paintingAudio);
	}*/
}
