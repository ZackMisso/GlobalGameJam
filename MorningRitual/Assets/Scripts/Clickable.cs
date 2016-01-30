using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {
  public StageGoal currentGoal;

  public void SetStageGoal(StageGoal param) {
    currentGoal = param;
  }

}
