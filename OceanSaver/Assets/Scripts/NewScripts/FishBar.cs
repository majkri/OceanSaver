using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class FishBar : MonoBehaviour
{
    public float fishbar = 2;
    public float Fish
    {
        get
        {
            return fishbar;
        }
        set
        {
            fishbar = Mathf.Clamp(value, 0, FishbarMax);
        }
    }
    public float FishbarMax = 14;

    public Image Fish_01;



    // Update is called once per frame
    public void Update()
    {
        UpdateFishBar();

       
        
           // ScoreManager.instance.ChangeScore(CoinValue);

        
    }

    private void UpdateFishBar()
    {
        Fish_01.fillAmount = Fish / FishbarMax;
        
    }


}
