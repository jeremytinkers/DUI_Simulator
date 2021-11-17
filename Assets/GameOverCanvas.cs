using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverCanvas : MonoBehaviour
{

    public Text scoreText;
    public Text timeText;

    public GameObject player;        //Public variable to store a reference to the player game object
    public CarScore playerComponent;

    //public Timer timerObject;

    private GameStats gameStatsObject;

    public void setGameOver() { 

    gameObject.SetActive(true);
    
    //Access and set Score Text
    playerComponent = player.GetComponent<CarScore>();
    scoreText.text = "Score: " + playerComponent.score.ToString();

    gameStatsObject = GameObject.Find("GameStatsCanvas").GetComponent<GameStats>();
    timeText.text = "Time: " + gameStatsObject.minutes + gameStatsObject.seconds;

    //timerObject = GameObject.Find("GameStatsCanvas").GetComponent<GameStats>();
    //timeText.text = "Time: " + timerObject.minutes + timerObject.seconds;

    }


}
