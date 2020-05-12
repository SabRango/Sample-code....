using UnityEngine;

public class Dragg : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    public float speed = 1.0F;
    public float g;
    private bool on=false;
    private bool offf=false;
    private Vector3 cuu;
   
    void OnMouseDown()
    {  
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }


    void OnMouseDrag()
    {
        on = true;
        /*Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;

        g = Time.deltaTime * speed;

        transform.position = Vector3.Lerp(transform.position, cursorPosition, g);*/
       


        
    }
    
    private void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            on = false;
            offf = true;
        }
        if (on)
        {
            Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
            cuu = cursorPosition;

            g = Time.deltaTime * speed;

            transform.position = Vector3.Lerp(transform.position, cursorPosition, g);
        }
        if (offf)
        {
            transform.position = Vector3.Lerp(transform.position, cuu, g);
        }
           
    }

}
   