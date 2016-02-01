using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {

    // replay for original julien scene
    public void ClickReplay()
    {
        Application.LoadLevel("roomtestscene_julien");
    }

    // replay for new scene
    public void ClickReplay1()
    {
        Application.LoadLevel("dana_scene");
    }

}
