//from https://www.youtube.com/watch?v=qo0A7MpD89w&ab_channel=Hegamurl 07:06
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void CloseGame()
    {
        Application.Quit();
    }

    public void StartLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
