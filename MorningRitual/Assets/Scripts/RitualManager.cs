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
    public StageGoal myStageGoal;

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
                NextStage();
        }
	}

    void NextStage()
    {
        switch (myStage)
        {
            case RitualStage.start:
                SetBathroomStage();
                break;
            default:
                myStage = RitualStage.done;
                break;
        }
    }

    void SetBathroomStage() {
        myStage = RitualStage.bathroom;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = true;
        myStageGoal.dropGoal = false;
        myStageGoal.keyObject = toilet;
        myStageGoal.placeGoal = null;
    }

}
