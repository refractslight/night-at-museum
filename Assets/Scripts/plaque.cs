using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque : MonoBehaviour {

	public GameObject plaqueObject;
	public bool isHidden = true;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void Appear() {
		gameObject.SetActive(true);
		bool isHidden = false;
	}

	void Disappear() {
		gameObject.SetActive (false);
		bool isHidden = true;
	}

}
