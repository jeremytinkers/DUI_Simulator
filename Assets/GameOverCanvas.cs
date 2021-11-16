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

    public Timer timerObject;

    public void setGameOver() { 

    gameObject.SetActive(true);
    
    //Access and set Score Text
    playerComponent = player.GetComponent<CarScore>();
    scoreText.text = "Score: " + playerComponent.score.ToString();

    timerObject = GameObject.Find("Timer").GetComponent<Timer>();
    timeText.text = "Time: " + timerObject.minutes + timerObject.seconds;
        
    }


}
