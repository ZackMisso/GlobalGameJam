using UnityEngine;
using System.Collections;

public class FPSWalker : MonoBehaviour {
  public float speed = 6.0f;
  private Vector3 moveDirection = Vector3.zero;

  public void FixedUpdate() {
    // Moves with arrow keys
    moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    moveDirection = transform.TransformDirection(moveDirection);
    //Vector3 forward = transform.forward;
    moveDirection *= speed * Time.deltaTime;
    //this.transform.Translate(moveDirection * Time.deltaTime,Space.World);
    this.transform.Translate(moveDirection.x,0,moveDirection.z,Space.World);
  }
}
