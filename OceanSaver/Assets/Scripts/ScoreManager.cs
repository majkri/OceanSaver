using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// This script was created to count the collectibles using this tutorial: https://www.youtube.com/watch?v=DZ-3g31jk90&t=96s&ab_channel=Xlaugts
// The creation of the script starts at 4:20

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;

    
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue) // Can I change "coinValue"" to another word?
    {
        score += coinValue;
        text.text = score.ToString(); // I removed "X" that they have in the tutorial because we don´t use it
    }

}
