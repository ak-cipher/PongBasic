using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public int SceneId;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalToWin;

    public void Update()
    {
        if(this.scorePlayer1 >= this.goalToWin)
        {
            Debug.Log("Player 1 won the game.");
            SceneManager.LoadScene(SceneId);
        }
        else if(this.scorePlayer2 >= this.goalToWin)
        {
            Debug.Log("Player 2 won the game.");
            SceneManager.LoadScene(SceneId);
        }
    }

    public void FixedUpdate()
    {
        Text uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();

        Text uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        scorePlayer2++;
    }
}
