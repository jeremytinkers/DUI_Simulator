using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Timer").SendMessage("FinishSim");
        print("Finish game!");
    }
}
