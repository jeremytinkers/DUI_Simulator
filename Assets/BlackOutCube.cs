using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOutCube : MonoBehaviour
{

    public GameObject currentGameObject;
    public float alpha = 0.0f;//intially full transparency
    //Get current material
    private Material currentMat;
    public int blackoutTrigger = 0; // public for testing pusporses
    private int blackoutInterval = 300;
    private int blackoutDuration = 40;

    // Start is called before the first frame update
    void Start()
    {
        currentGameObject = gameObject;
        currentMat = currentGameObject.GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        blackoutTrigger++;
  
        if (blackoutTrigger % blackoutInterval == 0)
        {
            //UnityEngine.Debug.Log("Blackout");
            ChangeAlpha(currentMat, 1.0f);

            if (blackoutInterval > 100) {
                blackoutInterval -= 30;
                blackoutDuration += 10;
                  }
        }

        if (blackoutTrigger % (blackoutInterval + blackoutDuration) == 0)
        {
            //UnityEngine.Debug.Log("Undo Blackout");
            ChangeAlpha(currentMat, 0.0f);
        }

    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

    }


}
