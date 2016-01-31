using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class UI : MonoBehaviour {

//What I need
public Slider progress; 
public float numStages; 


	// Use this for initialization
	void Start () {
		progress.minValue = 0; 
		progress.maxValue = numStages; 	
		progress.value = 0; 
	}

	//Incriment the slider on completing a task
	public void Progress () {
		if (progress == null) {
			Debug.Log("some"); 
		}
		progress.value = progress.value + 1; 
	}

}
