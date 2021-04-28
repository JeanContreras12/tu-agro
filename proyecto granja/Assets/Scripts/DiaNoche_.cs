using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaNoche : MonoBehaviour
{
    //variables
    public float min;
    
    // Update is called once per frame
    void Update()
    {
        //dia =24min
        min += 1 * Time.deltaTime;// 1 seg = 1 min
        //60min=1hr   24hr
        if (min >= 1440)//1140 =24
        {
            min = 0;
        }

        
    }
}
