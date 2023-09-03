using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimedScoring : Scoring
{
    /*
    public Text HighScoreText;
    private int highScore = 0;

    public GameObject timerStartButtonParent;
    public GameObject timerTextParent;
    public Text timerText;
    public float totalTime = 60f; // Set the total time for the countdown in seconds
    private float currentTime;
    private bool timeStart = false;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime;
        score = 0;
    }
    
    public void AddScore(int tScore)
    {
        score += tScore;
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score: " + score;
    }
    
    public void StartTimer()
    {
        foreach (Transform child in timerStartButtonParent.transform)
        {
            child.gameObject.SetActive(false);
        }
        foreach (Transform child in timerTextParent.transform)
        {
            child.gameObject.SetActive(true);
        }
        timeStart = true;
    }

    public void UpdateHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
        }
        HighScoreText.text = "High Score: " + highScore;
    }
    private void UpdateTimerUI()
    {
        // Update the UI Text element to display the remaining time
        timerText.text = "" + currentTime;
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (timeStart)
        {
            UpdateScore();
            UpdateHighScore();
            // Ensure the timer doesn't go below zero
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime; // Decrease time by the time passed since last frame
                UpdateTimerUI();
            }
            else
            {
                timeStart = false;
                foreach (Transform child in timerStartButtonParent.transform)
                {
                    child.gameObject.SetActive(true);
                }
                foreach (Transform child in timerTextParent.transform)
                {
                    child.gameObject.SetActive(false);
                }
                // Timer has reached zero, handle the end of the timer (e.g., game over)
                // You can add your custom logic here
            }
        }
    }
    */
}
