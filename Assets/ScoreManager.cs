using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    //public static ScoreManager instance;

    public TMP_Text scoreText;
    
    int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore(0);
    }
    

    // Update is called once per frame
    public void UpdateScore(int points)
    {
        Debug.Log("TEST");
        score += points;
        scoreText.text = "Score: " + score; 
    }
}
