using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour
{

    public GameObject player;        //Public variable to store a reference to the player game object
    public CarScore playerComponent;
    private Vector3 offset;            //Private variable to store the offset distance between the player and camera

    //Used to change score card's test
    TextMesh text;

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //offset = transform.position - player.transform.position;

        text = gameObject.GetComponent("TextMesh") as TextMesh;

        playerComponent = player.GetComponent<CarScore>();

    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //transform.position = player.transform.position + offset;
        
        if (playerComponent)
        {
            //Debug.Log("socre in scorecontroller: " + playerComponent.score);
            text.text = "Score: " + playerComponent.score.ToString();
        }

    }
}