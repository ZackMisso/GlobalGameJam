using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {
  public StageGoal currentGoal;
  public string audioTag;
  public bool active=false;

  public void SetStageGoal(StageGoal param) {
    currentGoal = param;
  }

  public void OnMouseDown() {
    Fabric.EventManager.Instance.PostEvent(audioTag, gameObject);
    if(active) {
      active = false;
      //Fabric.EventManager.Instance.PostEvent(audioTag, this);
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
