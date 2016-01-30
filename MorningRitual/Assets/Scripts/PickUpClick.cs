using UnityEngine;
using System.Collections;

public class PickUpClick : MonoBehaviour {

public GameObject looker; //refers to player or camera, assumes mouse follows it
public float distance; 
private bool hold; 

	// Use this for initialization
	void Start () {
		hold = false; 
	}

	void Update () {
		if (hold == true){
			//off is the distance times the unit vector of the player's forward
			Vector3 off = distance*(looker.transform.forward)/(looker.transform.forward.magnitude); 
			//pos is the new position of the object = player position pluss offset (off)
			Vector3 pos = looker.transform.position + off; 
			transform.position = pos; 
			if (Input.GetMouseButtonDown(1)){
				hold = false; 
			}
		}
	}

	//When clicked
	void OnMouseDown(){
		if(hold == false){
			hold = true; 
		}
	}
}
