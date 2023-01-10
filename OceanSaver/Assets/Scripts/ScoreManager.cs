using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

// This script was created to count the collectibles using this tutorial: https://www.youtube.com/watch?v=DZ-3g31jk90&t=96s&ab_channel=Xlaugts
// The creation of the script starts at 4:20
[ExecuteInEditMode()]
public class ScoreManager : MonoBehaviour
{
    //normal score 
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;

   
    //fishBar score
    public Image Fish_01;
    public Image Fish_02;
    public Image Fish_03;


    // normal score
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        //fishBar score
        Fish_02.enabled = false;
        Fish_03.enabled = false;
    }

    //fishbar score
    private void FixedUpdate()
    {
        UpdateFishBar();
    }

    //normal score
    public void ChangeScore(int coinValue) // Can I change "coinValue"" to another word?
    {
        score += coinValue;
        text.text = score.ToString(); // I removed "X" that they have in the tutorial because we don´t use it
    }

    //fishbar score
    private void UpdateFishBar()
    {
        Fish_01.fillAmount = score*0.1f;

        //this score*0.1f is the formula/calculation to fill a fish =10 plastic items collected
        //fillAmount goes from 0 to 1 then for 10 collectible we divide 1/10

        if (Fish_01.fillAmount == 1)
        {
        //the second fish_02 starts counting by subtracting the value of the first fishbar(10)
            Fish_02.fillAmount = (score - 10) * 0.1f;
            Fish_02.enabled = true;
            
           
        }
        if (Fish_02.fillAmount == 1)
        {
            //the second fish_03 starts counting by subtracting the value of the first and second fishbar(20)
            Fish_03.fillAmount = (score - 20) * 0.1f;
            Fish_03.enabled = true;  
            
        }

       
    }


}
