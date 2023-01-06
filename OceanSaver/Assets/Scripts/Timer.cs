using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//tutorial here: https://www.youtube.com/watch?v=HmHPJL-OcQE

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public Text timerText;
    public AudioSource source;
    public GameObject gameOverPanel;




    //Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
           

        }
        

        DisplayTime(timeValue);
        
        if (timeValue < 10)
        {
            
                source.enabled=true;

            if (timeValue <= 0)
            {
                gameOverPanel.SetActive(true);
            }
        }

    }
        

        

        
       

    

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    
}

