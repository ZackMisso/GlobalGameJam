using UnityEngine;
using System.Collections;

public class FPSWalker : MonoBehaviour {
  float speed = 6.0f;
  //float jumpSpeed = 8.0;
  //float gravity = 20.0;

  private Vector3 moveDirection = Vector3.zero;
  private bool grounded = false;

  public void FixedUpdate() {
    if (grounded) {
      // We are grounded, so recalculate movedirection directly from axes
      moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
      moveDirection = transform.TransformDirection(moveDirection);
      moveDirection *= speed;

      //if (Input.GetButton ("Jump")) {
      //  moveDirection.y = jumpSpeed;
      //}
    }
    // Apply gravity
    //moveDirection.y -= gravity * Time.deltaTime;
    // Move the controller
    //var controller : CharacterController = GetComponent(CharacterController);
    //var flags = controller.Move(moveDirection * Time.deltaTime);
    //grounded = (flags & CollisionFlags.CollidedBelow) != 0;
  }
  //@script RequireComponent(CharacterController)
}
