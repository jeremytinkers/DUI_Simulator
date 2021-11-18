using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverCanvas : MonoBehaviour
{

    public Text scoreText;
    public Text timeText;
    public Text verdict;


    public GameObject player;        //Public variable to store a reference to the player game object
    public CarScore playerComponent;
    private int pScore=0;

    //public Timer timerObject;

    private GameStats gameStatsObject;

    public void setGameOver() { 

    gameObject.SetActive(true);
    
    //Access and set Score Text
    playerComponent = player.GetComponent<CarScore>();
    pScore = playerComponent.score;

    scoreText.text = "Score: " + pScore.ToString();

        //conditional colouring based on score
        if (pScore >= 0 && pScore < 20)
        {
            //Green, level 0
            scoreText.color = Color.green;
            verdict.color = Color.green;
            verdict.text = "VERDICT: Sober,  Level 0 -> 0.00% - 0.02% bac";

        }
        else if (pScore >= 20 && pScore <60)
        {
            //yellow, level 1
            scoreText.color = Color.yellow;
            verdict.color = Color.yellow;
            verdict.text = "VERDICT: Wealky Intoxicated,  Level 1 -> 0.02% - 0.05% bac";
        }
        else if (pScore >= 60 && pScore < 100)
        {
            //magenta, level 2
            scoreText.color = Color.magenta;
            verdict.color = Color.magenta;
            verdict.text = "VERDICT: Moderately Intoxicated,  Level 2 -> 0.05% - 0.08% bac";
        }
        else
        {
            //red, level 3
            scoreText.color = Color.red;
            verdict.color = Color.red;
            verdict.text = "VERDICT: Severly Intoxicated,  Level 3 ->  >= 0.08% bac";
        }
   


    gameStatsObject = GameObject.Find("GameStatsCanvas").GetComponent<GameStats>();
    timeText.text = "Time: " + gameStatsObject.minutes + gameStatsObject.seconds;

    //timerObject = GameObject.Find("GameStatsCanvas").GetComponent<GameStats>();
    //timeText.text = "Time: " + timerObject.minutes + timerObject.seconds;

    }


}
