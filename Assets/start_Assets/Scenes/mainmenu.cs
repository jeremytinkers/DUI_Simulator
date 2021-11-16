using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame() {  
        //give the scene name in the argument
        SceneManager.LoadScene("DemoScene");  
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
