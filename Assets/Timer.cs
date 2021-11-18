using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    TextMesh text;
    private float startTime;
    private bool finished = false;
    public string minutes = "";
    public string seconds = "";
    private float t = 0;


    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent("TextMesh") as TextMesh;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finished)
        {
            t = Time.time - startTime;
            print("time: " + t);
            minutes = ((int)t / 60).ToString();
            seconds = (t % 60).ToString("f2");
        }

        text.text = "Time: " + t.ToString();


    }

    public void FinishSim()
    {
        finished = true;
        text.color = Color.yellow;
        print("message received!");
    }
}
