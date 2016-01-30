using UnityEngine;
using System.Collections;

public class RitualManager : MonoBehaviour {

    // all the stages of our ritual
    public enum RitualStage
    {
        start, bathroom, shower, getDressed, breakfast, coffee, leave, done
    }

    public RitualStage myStage;
    float startDelay;

    public GameObject toilet, showerKnob, showerKnobPlace, closet;

	// Use this for initialization
	void Start () {
        myStage = RitualStage.start;
        startDelay = 5f;
    }

	// Update is called once per frame
	void Update () {
	    if (myStage == RitualStage.start)
        {
            startDelay -= Time.deltaTime;
            if (startDelay <= 0)
                myStage = RitualStage.bathroom;
        }
	}
}
