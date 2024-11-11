using UnityEngine;
using TMPro;

public class ClickerScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText; // Optional
    private int score = 0;
    private float timer = 30f; // 30-second timer
    private bool isGameActive = true;

    // Increment score when the button is clicked
    public void OnButtonClick()
    {
        if (isGameActive)
        {
            score++;
            scoreText.text = "Score: " + score;
        }
    }

    void Update()
    {
        if (isGameActive)
        {
            timer -= Time.deltaTime;

            if (timerText != null)
                timerText.text = "Time: " + Mathf.Ceil(timer);

            if (timer <= 0)
            {
                isGameActive = false;
                if (timerText != null)
                    timerText.text = "Time's up!";
            }
        }
    }
}
