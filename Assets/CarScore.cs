﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScore : MonoBehaviour
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
        //AI Pedestrian
        if (other.gameObject.layer == 11)
        {
            Destroy(other.gameObject);
            score+=10;
            //Debug.Log("Fatality Rate: " + score);
        }
        else
        {
            print("ontriggerenter triggered");
        }
        //AI Car
        if (other.gameObject.layer == 12)
        {
            score += 5;
            //Debug.Log("Fatality Rate: " + score);
            print("AI CAR ontriggerenter");
            Debug.Log("AI CAR ontriggerenter");
        }

    }

    private void OnCollisionEnter(Collider other)
    {
        
        //AI Car
        if (other.gameObject.layer == 12)
        {
            Destroy(other.gameObject);
            score += 5;
            print("AI CAR oncollisionenter");
            //Debug.Log("Fatality Rate: " + score);
        }

        print("oncollisionenter triggered");

    }

}
