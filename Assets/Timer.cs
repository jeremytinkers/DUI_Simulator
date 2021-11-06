using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    TextMesh text;
    private float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent("TextMesh") as TextMesh;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        text.text = "Time: " + minutes + seconds;

    }
}
