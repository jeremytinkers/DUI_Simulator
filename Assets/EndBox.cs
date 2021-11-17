using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBox : MonoBehaviour
{
    public GameOverCanvas gameOver;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {

            GameObject.Find("GameStatsCanvas").SendMessage("FinishSim");

            //Activate Game Over Screen
            gameOver.setGameOver();

            print("Finish game!");
        }
    }
}
