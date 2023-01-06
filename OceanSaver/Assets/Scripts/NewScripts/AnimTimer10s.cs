using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTimer10s : StateMachineBehaviour
{
    public float timeValue;
 
    private Animation timerHurrayAnim;

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


        if (timeValue <= 10)
        {

            timerHurrayAnim.enabled = true;

            {

            }
        }
    }
}
