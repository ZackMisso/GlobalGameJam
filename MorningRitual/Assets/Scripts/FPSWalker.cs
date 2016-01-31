using UnityEngine;
using System.Collections;

public class FPSWalker : MonoBehaviour {
  public float speed = 2.0f;

  // Instructions to make move ::
  // Add mesh collider to scenery
  // Add rigid body to camera
  // Add spherical collider to camera
  // Add Mouse Look and FPS Walker scripts
  // Adjust for scenery

  public void FixedUpdate() {
    // Moves with arrow keys
    Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    moveDirection = transform.TransformDirection(moveDirection);
    moveDirection *= speed;

		if (moveDirection.magnitude >= 0.3f) {
			//Debug.Log ("walking");
			Fabric.EventManager.Instance.PostEvent("PlayFootsteps", gameObject);
		} 
		//else if (moveDirection.magnitude < 0.3) {
		//	Debug.Log ("not walking");
		//}

    if (GetComponent<Rigidbody>())
      GetComponent<Rigidbody>().velocity = new Vector3(moveDirection.x,0,moveDirection.z);
  }
}
