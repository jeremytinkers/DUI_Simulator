using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{

    public Text scoreText;
    public Text timeText;

    public GameObject player;        //Public variable to store a reference to the player game object
    public CarScore playerComponent;

    private Timer timerObject;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    void Update()
    {
        //Access and set Score Text
        playerComponent = player.GetComponent<CarScore>();
        scoreText.text = "Fatality Rate: " + playerComponent.score.ToString();

        timerObject = GameObject.Find("Timer").GetComponent<Timer>();
        timeText.text = "Timer: " + timerObject.minutes + timerObject.seconds;
    }

}
