using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBox : MonoBehaviour
{
    public GameOverCanvas gameOver;

    public Canvas gameStatsCanvasPointer;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {

            gameStatsCanvasPointer.SendMessage("FinishSim");

            //Activate Game Over Screen
            gameOver.setGameOver();

            print("Finish game!");
        }
    }
}
