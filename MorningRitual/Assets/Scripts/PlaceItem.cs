using UnityEngine;
using System.Collections;

public class PlaceItem : MonoBehaviour {

public string destination; 
private PickUpClick puc; 

	// Use this for initialization
	void Start () {
		puc = GetComponent<PickUpClick>();
	}


	//When where it needs to be
	void OnTriggerEnter (Collider other){
		if (other.tag == destination){
			puc.hold = false; 
			Destroy(GetComponent<Rigidbody>()); 
			transform.position = other.transform.position; 
			transform.forward = other.transform.forward;
			transform.up = other.transform.up; 
		}
	}
}
