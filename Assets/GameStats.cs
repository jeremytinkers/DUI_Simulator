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

    //private Timer timerObject;

    private float startTime;
    private bool finished = false;
    public string minutes = "";
    public string seconds = "";

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

    }

    void Update()
    {
        //Access and set Score Text
        playerComponent = player.GetComponent<CarScore>();
        scoreText.text = "Fatality Rate: " + playerComponent.score.ToString();

        if (!finished)
        {
            float t = Time.time - startTime;
            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("f2");
        }

        timeText.text = "Time: " + minutes + seconds;

        //Alternative Method:-
        //timerObject = GameObject.Find("Timer").GetComponent<Timer>();
        //timeText.text = "Timer: " + timerObject.minutes + timerObject.seconds;
    }

    public void FinishSim()
    {
        finished = true;
        timeText.color = Color.yellow;
        print("message received!");
    }

}
