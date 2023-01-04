// from https://www.youtube.com/watch?v=qo0A7MpD89w&ab_channel=Hegamurl 11:27 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControls : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
        
    }
}
