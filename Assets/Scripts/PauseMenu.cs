using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;
    public KeyCode pause;

    private bool onPaused = false;

	void Start () {
        pauseMenu.SetActive(false);
	}
	
	void Update () {
        if (Input.GetKeyDown(pause))
        {
            onPaused = !onPaused;
        }

        if (onPaused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        } else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public bool isPaused()
    {
        return onPaused;
    }
}
