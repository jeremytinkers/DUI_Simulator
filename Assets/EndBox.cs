using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBox : MonoBehaviour
{
    public GameOverCanvas gameOver;
    
    private void OnTriggerEnter(Collider other)
    {

        GameObject.Find("Timer").SendMessage("FinishSim");
        
        //Activate Game Over Screen
        gameOver.setGameOver();
        
        print("Finish game!");
    }
}
