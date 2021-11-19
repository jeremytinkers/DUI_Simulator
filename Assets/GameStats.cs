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
    private int score = 0;
    
    //private Timer timerObject;

    private float startTime;
    private bool finished = false;
    public string timeFinal = "";
    public float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

    }

    void Update()
    {
        //Access and set Score Text
        playerComponent = player.GetComponent<CarScore>();
        score = playerComponent.score;
        scoreText.text = "Fatality Rate: " + score.ToString();

        //conditional colouring based on score
        if (score >= 0 && score < 20)
        {
            //Green, level 0
            scoreText.color = Color.green;

        }
        else if (score >= 20 && score < 60)
        {
            //yellow, level 1
            scoreText.color = Color.yellow;
        }
        else if (score >= 60 && score < 100)
        {
            //magenta, level 2
            scoreText.color = Color.magenta;
        }
        else
        {
            //red, level 3
            scoreText.color = Color.red;
        }

        //Timer
        if (!finished)
        {
            t = Time.time - startTime;
            timeFinal = t.ToString("f0");
        }

        timeText.text = "Time: " + timeFinal + "s";
        //print("timefinal in gamestats:" + timeFinal);

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
