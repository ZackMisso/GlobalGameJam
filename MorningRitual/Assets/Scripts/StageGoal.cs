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
    else if(dropGoal) {
      // do stuffs
    }
    else if(clickGoal) {
      // do stuffs
    }
  }
}
