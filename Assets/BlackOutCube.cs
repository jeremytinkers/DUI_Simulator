using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOutCube : MonoBehaviour
{

    public GameObject currentGameObject;
    public float alpha = 0.0f;//intially full transparency
    //Get current material
    private Material currentMat;
    public int blackoutTrigger = 0;

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
  
        if (blackoutTrigger == 500)
        {
            UnityEngine.Debug.Log("Blacout");
            ChangeAlpha(currentMat, 1.0f);
        }

        if (blackoutTrigger ==560)
        {
            UnityEngine.Debug.Log("Undo Blacout");
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
