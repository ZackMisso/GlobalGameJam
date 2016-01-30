using UnityEngine;
using System.Collections;

public class RitualManager : MonoBehaviour {

    // all the stages of our ritual
    public enum RitualStage
    {
        start, bathroom, shower, getDressed, breakfast,
        drawerOpen, coffeeDropCup, coffeeMake, coffeeDrink, leave, done
    }

    public RitualStage myStage;
    float startDelay;

    public GameObject toilet, showerKnob, closet, eggs, drawer, cup, coffeeMaker, frontDoor;
    public StageGoal myStageGoal;

	// Use this for initialization
	void Start () {
        myStage = RitualStage.start;
        startDelay = 5f;
        gameObject.AddComponent<StageGoal>();
        myStageGoal = GetComponent<StageGoal>();
        myStageGoal.manager = this;
        NextStage();
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

    // function that transitions to the next stage
    // assuming that the completed conditions are met
    public void NextStage()
    {
        switch (myStage)
        {
            case RitualStage.start:
                SetBathroomStage();
                break;
            case RitualStage.bathroom:
                SetShowerStage();
                break;
            case RitualStage.shower:
                SetGetDressedStage();
                break;
            case RitualStage.getDressed:
                SetBreakfastStage();
                break;
            case RitualStage.breakfast:
                SetDrawerOpenStage();
                break;
            case RitualStage.drawerOpen:
                SetCoffeeCupStage();
                break;
            case RitualStage.coffeeDropCup:
                SetCoffeeMakeStage();
                break;
            case RitualStage.coffeeMake:
                SetCoffeeDrinkStage();
                break;
            case RitualStage.coffeeDrink:
                SetLeaveStage();
                break;
            default:
                myStage = RitualStage.done;
                break;
        }
    }

    // setup the bathroom stage and related objects and flags
    // click on the toilet
    void SetBathroomStage() {
        myStage = RitualStage.bathroom;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = true;
        myStageGoal.dropGoal = false;
        myStageGoal.keyObject = toilet;
        toilet.AddComponent<Clickable>();
        toilet.GetComponent<Clickable>().SetStageGoal(myStageGoal);
        myStageGoal.placeGoal = null;
    }

    // setup the shower stage and related objects and flags
    // pick up shower knob and drop in the place where it goes
    void SetShowerStage()
    {
        myStage = RitualStage.shower;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = false;
        myStageGoal.dropGoal = true;
        myStageGoal.keyObject = showerKnob;
        PlaceItem pi = showerKnob.GetComponent<PlaceItem>();
        pi.currentGoal = myStageGoal;
    }

    // setup the get dresses stage and related objects and flags
    // click on the closet
    void SetGetDressedStage()
    {
        myStage = RitualStage.getDressed;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = true;
        myStageGoal.dropGoal = false;
        myStageGoal.keyObject = closet;
        closet.AddComponent<Clickable>();
        closet.GetComponent<Clickable>().SetStageGoal(myStageGoal);
        myStageGoal.placeGoal = null;
    }

    // setup the breakfast stage and related objects and flags
    // pick up eggs and drop in the frying pan
    void SetBreakfastStage()
    { // TO BE FIXED
        myStage = RitualStage.breakfast;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = false;
        myStageGoal.dropGoal = true;
        myStageGoal.keyObject = eggs;
        myStageGoal.placeGoal = fryingPan;
        myStageGoal.placeGoal.currentGoal = myStageGoal;
    }

    // setup the cofee drop cup in the coffee maker stage and related objects and flags
    // pick up the cup and drop it in the coffee maker
    void SetDrawerOpenStage()
    {
        myStage = RitualStage.drawerOpen;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = true;
        myStageGoal.dropGoal = false;
        myStageGoal.keyObject = drawer;
        myStageGoal.placeGoal = null;
        drawer.AddComponent<Clickable>();
        drawer.GetComponent<Clickable>().SetStageGoal(myStageGoal);
    }

    // setup the cofee drop cup in the coffee maker stage and related objects and flags
    // pick up the cup and drop it in the coffee maker
    void SetCoffeeCupStage()
    { // TO BE FIXED
        myStage = RitualStage.coffeeDropCup;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = false;
        myStageGoal.dropGoal = true;
        myStageGoal.keyObject = cup;
        myStageGoal.placeGoal = cupPlace;
        myStageGoal.placeGoal.currentGoal = myStageGoal;
    }

    // setup the cofee stage and related objects and flags
    // click on the coffee maker
    void SetCoffeeMakeStage()
    {
        myStage = RitualStage.coffeeMake;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = true;
        myStageGoal.dropGoal = false;
        myStageGoal.keyObject = coffeeMaker;
        coffeeMaker.AddComponent<Clickable>();
        coffeeMaker.GetComponent<Clickable>().SetStageGoal(myStageGoal);
        myStageGoal.placeGoal = null;
    }

    // setup the drink cofee stage and related objects and flags
    // click the cup
    void SetCoffeeDrinkStage()
    {
        myStage = RitualStage.coffeeDrink;
        myStageGoal.walkGoal = false;
        myStageGoal.clickGoal = true;
        myStageGoal.dropGoal = false;
        myStageGoal.keyObject = cup;
        cup.AddComponent<Clickable>();
        cup.GetComponent<Clickable>().SetStageGoal(myStageGoal);
        myStageGoal.placeGoal = null;
    }

    // setup the leave the house stage and related objects and flags
    // get to the front door
    void SetLeaveStage()
    {
        myStage = RitualStage.leave;
        myStageGoal.walkGoal = true;
        myStageGoal.clickGoal = false;
        myStageGoal.dropGoal = false;
        myStageGoal.keyObject = frontDoor;
        myStageGoal.placeGoal = null;
    }
}
