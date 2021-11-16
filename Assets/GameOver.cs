using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour

{
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        count++;
        if (count == 50)
        {
            gameObject.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
