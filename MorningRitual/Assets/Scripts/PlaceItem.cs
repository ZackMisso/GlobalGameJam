using UnityEngine;
using System.Collections;

public class PlaceItem : MonoBehaviour {

	public StageGoal currentGoal;
	public GameObject destination;
	private PickUpClick puc;

	//When where it needs to be
	void OnTriggerEnter (Collider other){
		if (other.gameObject == destination){
			puc.hold = false;
			Destroy(GetComponent<Rigidbody>());
			transform.position = other.transform.position;
			transform.forward = other.transform.forward;
			transform.up = other.transform.up;
			currentGoal.manager.NextStage();
		}
	}
}
