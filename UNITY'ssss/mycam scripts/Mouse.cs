using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    /*public float mouseSpeedMultiplier = 20;
    public float smoothSpeed = 0.04f;
    private float mouseX;
    private float mouseY;
    void OnMouseDrag()
    {
        mouseX += Input.GetAxis("Mouse X") * mouseSpeedMultiplier* Mathf.Deg2Rad;
        //mouseY += Input.GetAxis("Mouse Y") * mouseSpeedMultiplier* Mathf.Deg2Rad;
    }

    void LateUpdate() //Cause we are using Lerp function

    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -mouseX, 0), smoothSpeed);
       /// transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -mouseY), smoothSpeed);

    }/**/
    public float rotationSpeed = 10.0F;
    public float rotationSpeed2 = 10.0F;
    public float lerpSpeed = 1.0F;
    public float kkk;
    private Vector3 theSpeed;
    private Vector3 avgSpeed;
    private bool isDragging = false;
    private Vector3 targetSpeedX;

    /*void OnMouseDown()
    {

        isDragging = true;
    }*/

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            isDragging = true;
        }

        if (Input.GetMouseButton(1) && isDragging)
        {
            theSpeed = new Vector3(-Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0.0F);
            avgSpeed = Vector3.Lerp(avgSpeed, theSpeed, Time.deltaTime * kkk);
            theSpeed = avgSpeed;
            transform.Rotate(Camera.main.transform.up * theSpeed.x * rotationSpeed, Space.World);
            transform.Rotate(Camera.main.transform.right * theSpeed.y * rotationSpeed, Space.World);
        }
        else
        {
            if (isDragging)
            {
                theSpeed = avgSpeed;
                isDragging = false;
            }
            float i = Time.deltaTime * lerpSpeed;
            theSpeed = Vector3.Lerp(avgSpeed, Vector3.zero, i);
            transform.Rotate(Camera.main.transform.up * theSpeed.x * rotationSpeed2, Space.World);
            transform.Rotate(Camera.main.transform.right * theSpeed.y * rotationSpeed2, Space.World);
        }

        /*transform.Rotate(Camera.main.transform.up * theSpeed.x * rotationSpeed, Space.World);
        transform.Rotate(Camera.main.transform.right * theSpeed.y * rotationSpeed, Space.World);*/
    }


}
