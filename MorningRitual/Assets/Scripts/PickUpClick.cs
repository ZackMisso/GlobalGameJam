using UnityEngine;
using System.Collections;

//https://www.youtube.com/watch?v=jOOdJZS987Y33344r4r

public class PickUpClick : MonoBehaviour {
    public GameObject looker; //refers to player or camera, assumes mouse follows it
    public string audioTag;
    public float distance;
    public float minDistance=3.0f;
    public bool hold;
    public bool active;

	// Use this for initialization
	void Start () {
		hold = false;
        active = false;
	}

	void Update () {
		if (active && hold == true){
      if(looker.GetComponent<StabilizingHack>().moved) {
        //off is the distance times the unit vector of the player's forward
        Vector3 off = distance * (looker.transform.forward);// /(looker.transform.forward.magnitude);
        //pos is the new position of the object = player position pluss offset (off)
        Vector3 pos = looker.transform.position + off;
        transform.position = pos;
        //so the object rotates with you
        transform.forward = looker.transform.forward;
      }
			if (Input.GetMouseButtonDown(1)){
				hold = false;
			}
		}
	}

    // When Clicked
    void OnMouseDown() {
		if(active && checkDistance())
			if(hold == false){
				hold = true;
        Fabric.EventManager.Instance.PostEvent(audioTag, gameObject);
      }
	}

	private bool checkDistance() {
		Vector3 position = transform.position;
		Vector3 otherPosition = looker.transform.position;
		float dist = (otherPosition-position).magnitude;
		return dist < minDistance;
	}

}
