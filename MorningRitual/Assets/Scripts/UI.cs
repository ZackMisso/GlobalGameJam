using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class UI : MonoBehaviour {

//What I need
public Slider progress; 
public float numStages; 


	// Use this for initialization
	void Start () {
		progress.minValue = -1; 
		progress.maxValue = numStages; 	
	}

	//Incriment the slider on completing a task
	public void Progress () {
		progress.value = progress.value + 1; 
	}

}
