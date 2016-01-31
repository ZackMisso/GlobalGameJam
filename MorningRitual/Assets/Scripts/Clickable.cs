using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {
  public StageGoal currentGoal;
  public bool active=false;

  public void SetStageGoal(StageGoal param) {
    currentGoal = param;
  }

  public void OnMouseDown() {
    if(active) {
      active = false;
      currentGoal.manager.NextStage();
    }
  }

  public void OnMouseEnter() {
    if(active) {
      // maybe implement an animation
    }
  }

  public void OnMouseExit() {
    if(active) {
      // maybe implement an animation
    }
  }
}
