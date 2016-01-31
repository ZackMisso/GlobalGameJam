using UnityEngine;
using System.Collections;

// This is a hack

public class StabilizingHack : MonoBehaviour {
  public bool moved;
  private float previousX;
  private float previousY;

  public void Update() {
    float x = Input.GetAxis("Horizontal");
    float y = Input.GetAxis("Vertical");
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = Input.GetAxis("Mouse Y");
    moved = false;
    if(x != 0.0f || y != 0.0f || mouseX != previousX || mouseY != previousY) {
      moved = true;
      previousX = mouseX;
      previousY = mouseY;
    }
  }
}
