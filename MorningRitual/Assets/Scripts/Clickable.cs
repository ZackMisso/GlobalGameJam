using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {
  public StageGoal currentGoal;

  public void SetStageGoal(StageGoal param) {
    currentGoal = param;
  }

  public void OnMouseDown() {
    currentGoal.manager.NextStage();
  }

  public void OnMouseEnter() {
    // maybe implement an animation
  }

  public void OnMouseExit() {
    // maybe implement an animation
  }
}
