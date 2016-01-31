﻿using UnityEngine;
using System.Collections;

public class PickUpClick : MonoBehaviour {

    public GameObject looker; //refers to player or camera, assumes mouse follows it
    public float distance; 
    public bool hold;
    public bool active;

	// Use this for initialization
	void Start () {
		hold = false;
        active = false;
	}

	void Update () {
		if (hold == true){
			//off is the distance times the unit vector of the player's forward
			Vector3 off = distance*(looker.transform.forward)/(looker.transform.forward.magnitude); 
			//pos is the new position of the object = player position pluss offset (off)
			Vector3 pos = looker.transform.position + off; 
			transform.position = pos; 
			//so the object rotates with you
			transform.forward = looker.transform.forward; 
			if (Input.GetMouseButtonDown(1)){
				hold = false; 
			}
		}
	}

	//When clicked
	void OnMouseDown(){
		if(active && hold == false){
			hold = true; 
		}
	}

}
