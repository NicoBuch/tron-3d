using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
    public KeyCode pause;
    public Text pauseText;

    private bool paused = false;

    void Update () {
//	    if (Input.GetKeyDown(pause))
//        {
//            if (paused)
//            {
//                Time.timeScale = 1;
//                paused = false;
//            }
//            else
//            {
//                Time.timeScale = 0;
//                paused = true;
//            }
//            setText();
//        }
	}

    public bool isPaused()
    {
        return paused;
    }

    void setText()
    {
        if (paused)
        {
            pauseText.text = "PAUSED";
        }
        else
        {
            pauseText.text = "";
        }
    }
}
