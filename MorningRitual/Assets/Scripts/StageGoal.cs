using UnityEngine;
using System.Collections;

public class StageGoal : MonoBehaviour {
  //public GameObject player;
  public RitualManager manager;
  public GameObject keyObject;
  //public PlaceItem placeGoal;
  public bool walkGoal;
  public bool dropGoal;
  public bool clickGoal;
  public bool active=false;

  public StageGoal() {
    manager = GetComponent<RitualManager>();
  }

  public void Update() {
    if(walkGoal&&active) {
      SphereCollider collider = keyObject.GetComponent<SphereCollider>();
      Vector3 position = transform.position;
      Vector3 cent = collider.center;
      float radius = collider.radius;
      float distance = (cent-position).magnitude;
      if(radius > distance) {
        // Handle stage Transition maybe
        active = false;
        manager.NextStage();
      }
    }
  }
}
