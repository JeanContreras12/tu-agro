using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaNoche : MonoBehaviour
{
    //variables
    public float min, grados;
    public float timeSpeed = 1;
    
    // Update is called once per frame
    void Update()
    {
        //dia =24min
        min += timeSpeed * Time.deltaTime;// 1 seg = 1 min
        //60min=1hr   24hr
        if (min >= 1440)//1140 =24
        {
            min = 0;
        }
        grados = min / 4;
        this.transform.localEulerAngles = new Vector3 (grados, -90f, 0f);

        
    }
}
