using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	public void playGame()
    {
        Application.LoadLevel("main");
    }

    public void instructions()
    {
        Application.LoadLevel("instructions");
    }

    public void backToMenu()
    {
        Application.LoadLevel("menu");
    }
}
