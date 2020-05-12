using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float dd=1;
    private float self;
    private float next;
    private float t=0;
    private float final;


     void Update()
    {
        

        Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, Camera.main.fieldOfView - Input.mouseScrollDelta.y*dd, t);

        
        t += 0.001f * Time.deltaTime;
        if (t > 1.0f)
        {
            float temp =Camera.main.fieldOfView - Input.mouseScrollDelta.y*dd;
             Camera.main.fieldOfView= Camera.main.fieldOfView - Input.mouseScrollDelta.y*dd ;
            Camera.main.fieldOfView = temp;
            t = 0.0f;
        }


        /*Camera.main.fieldOfView -=Input.mouseScrollDelta.y*dd ;*/
    }
    
}


