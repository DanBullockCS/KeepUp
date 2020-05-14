// Displays your score on the end screen
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour {
    TMP_Text scoreText = null;
    [SerializeField] TMP_Text highScoreText = null;
    private int score = 0;
    private int highScore = 0;

    void Start() {
        // Get High score from PlayerPrefs
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        score = PlayerPrefs.GetInt("Score");

        // Update scores if they beat high score
        if (score > highScore) {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        // Display scores
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }
}
