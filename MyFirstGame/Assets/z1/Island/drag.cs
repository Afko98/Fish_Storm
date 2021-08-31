using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class drag : MonoBehaviour
{
    bool uslov = false;
   
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(transform.position.x <(cursorPos.x + 0.3f) && transform.position.x>(cursorPos.x-0.3f) && transform.position.y < (cursorPos.y +0.3f)&& transform.position.y>(cursorPos.y - 0.3f))
        {
            transform.position = cursorPos;
            uslov = true;
        }
        if ((cursorPos.y > 0.8 || cursorPos.y < -2.3f || cursorPos.x > 2.4f || cursorPos.x < -2.4f) && uslov)
        {
            if (cursorPos.y > 0.8)
            {
 transform.position = new Vector2(transform.position.x, 0.6f);
                GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-6f, 6f), Random.Range(-7f, 0f));
            }
               
            if(cursorPos.y < -2.3f)
            {

                transform.position = new Vector2(transform.position.x, -2.1f);
                GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-6f, 6f), Random.Range(0f, 7f));
            }
            if (cursorPos.x > 2.4f)
            {
transform.position = new Vector2(2.2f, transform.position.y);
                GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-13f, 0f), Random.Range(-6f, 6f));
            }
                
            if (cursorPos.x < -2.4f)
            {
transform.position = new Vector2(-2.2f, transform.position.y);
                GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(0f, 13f), Random.Range(-6f, 6f));
            }
                
            uslov = false;
            
           
        }
    }
    
}