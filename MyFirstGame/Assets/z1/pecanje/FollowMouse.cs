using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
    public static float moveSpeed = 0.004f;
    public float moveSpeedCam = 0.8f;
    public bool uslov;
    public int brojObicnih, brojStruja, brojUkupnih;
    public float yKoordinata = 0f;


    private void Update()
    {
        uslov = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMove>().uslovVracanja;

        if (!uslov)
        {
            PremaDole();
        }
        else
        {
            PremaGore();
        }
        
    }
    void PremaDole()
    {
       
   
      
            moveSpeedCam += Time.deltaTime /90;
        if (moveSpeedCam > 2)
            moveSpeedCam = 2f;
        
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
        transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeedCam * Time.deltaTime,-350f);
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
        transform.position = new Vector3(transform.position.x, transform.position.y + (moveSpeedCam+4.7f) * Time.deltaTime, -350f);
    }
    
}
