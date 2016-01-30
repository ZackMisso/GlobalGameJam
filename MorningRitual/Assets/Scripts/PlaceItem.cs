using UnityEngine;
using System.Collections;

public class PlaceItem : MonoBehaviour {

public StageGoal currentGoal;
public string destination;
private PickUpClick puc;

	// Use this for initialization
	void Start () {
		puc = GetComponent<PickUpClick>();
	}


	//When where it needs to be
	void OnTriggerEnter (Collider other){
		if (other.gameObject == currentGoal.keyObject){
			puc.hold = false;
			Destroy(GetComponent<Rigidbody>());
			transform.position = other.transform.position;
			transform.forward = other.transform.forward;
			transform.up = other.transform.up;
			currentGoal.manager.NextStage();
		}
	}
}
