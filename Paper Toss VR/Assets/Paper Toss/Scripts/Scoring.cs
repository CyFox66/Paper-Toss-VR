using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text ScoreText;
    private int score = 0;

    public bool enabledTimed;
    private bool canScore;

    [SerializeField]
    private Text HighScoreText;
    private int highScore = 0;

    [SerializeField]
    private GameObject timerStartButtonParent;
    [SerializeField]
    private GameObject timerTextParent;
    [SerializeField]
    private Text timerText;
    [SerializeField]
    private float totalTime = 60.9f; // Set the total time for the countdown in seconds
    private float currentTime;
    private bool timeStart = false;
    // Start is called before the first frame update
    void Start()
    {
        if (enabledTimed)
        {
            canScore = false;
        }
        else
        {
            canScore = true;
        }
        currentTime = totalTime;
        score = 0;
    }

    public void AddScore(int tScore)
    {
        if (canScore)
        {
            score += tScore;
        }
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score: " + score;
    }

    public void StartTimer()
    {
        foreach (Transform child in timerStartButtonParent.transform)
        {
            Debug.Log("Timer Button Deactivated");
            child.gameObject.SetActive(false);
        }
        foreach (Transform child in timerTextParent.transform)
        {
            Debug.Log("Timer Text Activated");
            child.gameObject.SetActive(true);
        }
        timeStart = true;
        score = 0;
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
        timerText.text = "" + (int)currentTime;
    }
    // Update is called once per frame
    protected void Update()
    {
        UpdateScore();

        if (enabledTimed)
        {
            UpdateHighScore();
            if (timeStart)
            {
                canScore = true;
                // Ensure the timer doesn't go below zero
                if (currentTime > 0)
                {
                    currentTime -= Time.deltaTime; // Decrease time by the time passed since last frame
                    UpdateTimerUI();
                }
                else
                {
                    timeStart = false;
                    canScore = false;
                    currentTime = totalTime;

                    foreach (Transform child in timerStartButtonParent.transform)
                    {
                        Debug.Log("Timer Button Activated");
                        child.gameObject.SetActive(true);
                    }
                    foreach (Transform child in timerTextParent.transform)
                    {
                        Debug.Log("Timer Text Deactivated");
                        child.gameObject.SetActive(false);
                    }
                    // Timer has reached zero, handle the end of the timer (e.g., game over)
                    // You can add your custom logic here
                }
            }
        }
    }
}
