using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
    public static float moveSpeed = 0.008f;
    
    public bool uslov;
    public int brojObicnih, brojStruja, brojUkupnih;
    public float yKoordinata = 0f;


    private void Update()
    {
        uslov = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMove>().uslovVracanja;

        if (!uslov)
        {
        if (CameraMove.boost1 || CameraMove.boost2)
            GetComponent<CapsuleCollider2D>().enabled = false;
        else
            GetComponent<CapsuleCollider2D>().enabled = true;


            PremaDole();
        }
        else
        {
            GetComponent<CapsuleCollider2D>().enabled = true;
            PremaGore();
        }

        
    }
    void PremaDole()
    {
       
   
      
            
        if (CameraMove.camspeed > 2)
            CameraMove.camspeed = 2f;
        
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (cursorPos.y <= 1)
            yKoordinata = cursorPos.y+1.2f;
        else
            yKoordinata = 1;
        if (cursorPos.x > 2.5)
            cursorPos.x = 2.5f;
        if (cursorPos.x < -2.5)
            cursorPos.x = -2.5f;
        
        Vector2 mousePosition = new Vector2(cursorPos.x, yKoordinata);

        transform.position= Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        transform.position = new Vector3(transform.position.x, transform.position.y - CameraMove.camspeed * Time.deltaTime,-350f);
        if (transform.position.y > Camera.main.transform.position.y + 5f)
            transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y + 5f, -350f);


    }
    void PremaGore()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (cursorPos.y < 0)
            yKoordinata = cursorPos.y;
        else
            yKoordinata = 0;
        Vector2 mousePosition = new Vector2(cursorPos.x, yKoordinata);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed*5f);
        transform.position = new Vector3(transform.position.x, transform.position.y + (CameraMove.camspeed + 4.7f) * Time.deltaTime, -350f);
    }
    
}
