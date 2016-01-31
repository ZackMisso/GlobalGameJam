using UnityEngine;
using System.Collections;

public class PlaceItem : MonoBehaviour {

	public StageGoal currentGoal;
	public GameObject destination;
	public PickUpClick puc;

	//When where it needs to be
	void OnTriggerEnter (Collider other){
		if (other.gameObject == destination && !puc.hold){
			Destroy(GetComponent<Rigidbody>());
			transform.position = other.transform.position;
			transform.forward = other.transform.forward;
			transform.up = other.transform.up;
      puc.active = false;
			currentGoal.manager.NextStage();
		}
	}
}
