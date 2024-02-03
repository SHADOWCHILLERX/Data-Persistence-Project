using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour
{
    public Text highScoreText;

    public InputField nameInputField;

    void Start()
    {
        // Retrieve high score from PlayerPrefs and display it
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore;

        // Load the player's name from PlayerPrefs and set it in the input field
        string playerName = PlayerPrefs.GetString("PlayerName", "");
        nameInputField.text = playerName;
    }

    public void SavePlayerName()
    {
        // Save the player's name to PlayerPrefs
        string playerName = nameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
    }
}
