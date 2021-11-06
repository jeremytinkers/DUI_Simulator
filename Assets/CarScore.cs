using System.Collections;
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
            Debug.Log("Fatality Rate: " + score);
        }
        //AI Car
        if (other.gameObject.layer == 12)
        {
            Destroy(other.gameObject);
            score += 5;
            Debug.Log("Fatality Rate: " + score);
        }

        print("SOmt");
    }

    private void OnCollisionEnter(Collider other)
    {
        
        //AI Car
        if (other.gameObject.layer == 12)
        {
            Destroy(other.gameObject);
            score += 5;
            print("AI CAR");
            Debug.Log("Fatality Rate: " + score);
        }

        
    }

}
