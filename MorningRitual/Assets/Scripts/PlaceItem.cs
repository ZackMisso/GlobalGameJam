using UnityEngine;
using System.Collections;

public class PlaceItem : MonoBehaviour {

	public StageGoal currentGoal;
	public GameObject destination;
	public PickUpClick puc;
	public string audioTag;
    public bool insideSphere;
    private Collider theOther;

    void Start()
    {
        insideSphere = false;
    }

	//When where it needs to be
	void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == destination){
            insideSphere = true;
            theOther = other;
		}
	}
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == destination)
        {
            insideSphere = false;
            theOther = null;
        }
    }

    // When Clicked
    void Update()
    {
        if (insideSphere && !puc.hold)
        {
            Destroy(GetComponent<Rigidbody>());
            transform.position = theOther.transform.position;
            transform.forward = theOther.transform.forward;
            transform.up = theOther.transform.up;
            puc.active = false;
            insideSphere = false;
            theOther.enabled = false;
						Fabric.EventManager.Instance.PostEvent(audioTag, gameObject);
            currentGoal.manager.NextStage();
        }
    }
}
