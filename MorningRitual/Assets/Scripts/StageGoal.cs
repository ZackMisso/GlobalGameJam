using UnityEngine;
using System.Collections;

public class StageGoal : MonoBehaviour {
  public RitualManager manager;
  public GameObject keyObject;
  public PlaceItem placeGoal;
  public bool walkGoal;
  public bool dropGoal;
  public bool clickGoal;

  public StageGoal() {
    manager = GetComponent<RitualManager>();
  }

  public void Update() {
    if(walkGoal) {
      // do stuffs
    }

    // These two should be handled elsewhere
    else if(dropGoal) {
      // do stuffs
    }
    else if(clickGoal) { // Needs to be tested
      // does nothing... blah handled by Clickable

      // Rays dont work well
      /*RaycastHit hit;
      float centerX = Screen.width / 2;
      float centerY = Screen.height / 2;
      Ray ray = Camera.ScreenPointToRay(Vector3(centerX, centerY, 0));
      if(Physics.Raycast(ray, out hit)) {
        if(hit.collider.gameObject == keyObject) {
          // handle Click stuffs if needed
          manager.NextStage();
        }
      }*/

      //if(hit.collider.tag == "clickableCube"{
      //  //hit.collider.gameObject now refers to the
      //  //cube under the mouse cursor if present
      //}
    }
  }
}
