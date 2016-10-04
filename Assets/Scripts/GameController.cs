using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
    public KeyCode pause;
    public Text finishedText;
    public GameObject player1;
    public GameObject player2;

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

    public void finished(GameObject player)
    {
        Time.timeScale = 0;
        if (player.tag == "Player1")
        {
            setText("PLAYER 2 WINS!");
        }
        else
        {
            setText("PLAYER 1 WINS!");
        }
    }

    void setText(string text)
    {
        finishedText.text = text;
    }
}
