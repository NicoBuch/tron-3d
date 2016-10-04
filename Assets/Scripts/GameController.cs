using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    public KeyCode pause;
    public Text finishedText;
    public GameObject player1;
    public GameObject player2;
    private System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
    private bool gameOver = false;

    private bool paused = false;

    void Update()
    {
        if (timer.IsRunning && timer.ElapsedMilliseconds > 1500 && gameOver)
        {
            timer.Stop();
            Time.timeScale = 1;
            Application.LoadLevel("menu");
        }

        if (!gameOver && Input.GetKeyDown(pause))
        {
            if (paused)
            {
                Time.timeScale = 1;
                paused = false;
                setText("");
            }
            else
            {
                Time.timeScale = 0;
                paused = true;
                setText("PAUSED");
            }
        }
    }

    public bool isPaused()
    {
        return paused;
    }

    public void finished(GameObject player)
    {
        timer.Reset();
        timer.Start();
        gameOver = true;
        Time.timeScale = 0.2f;
        if (player.tag == "Player1")
        {
            setText("ORANGE WINS!");
        }
        else
        {
            setText("BLUE WINS!");
        }
    }

    void setText(string text)
    {
        finishedText.text = text;
    }
}