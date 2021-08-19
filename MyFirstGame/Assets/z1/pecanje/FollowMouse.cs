using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
    public static float moveSpeed = 0.008f;
    public static float boostTime,inGameBoostTime;
    public bool uslov;
    public int brojObicnih, brojStruja, brojUkupnih;
    public float yKoordinata = 0f;
    public GameObject boostPanel,fuelIcon;
    public Text tekst;

    private void Start()
    {
        inGameBoostTime = boostTime;
        if (boostTime < 0.01f)
            fuelIcon.SetActive(false);
        tekst.GetComponent<Text>().text = "" + (int)(inGameBoostTime * 10);

    }

    private void Update()
    {
        if (inGameBoostTime < 0.01f)
        {
            boostPanel.SetActive(false);
        }
        uslov = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraMove>().uslovVracanja;

        if (!uslov)
        {
        if (CameraMove.boost1 || CameraMove.boost2 || CameraMove.brojZakacenihRibica>=CameraMove.brojMaxZakacenihUIgri)
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


        
            
        
        
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (cursorPos.y <= 1)
            yKoordinata = cursorPos.y+0.2f;
        else
            yKoordinata = 1;
        if (cursorPos.x > 2.5)
            cursorPos.x = 2.5f;
        if (cursorPos.x < -2.5)
            cursorPos.x = -2.5f;
        
        Vector2 mousePosition = new Vector2(cursorPos.x, yKoordinata);

        transform.position= Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        

        if (transform.position.y > Camera.main.transform.position.y + 3.2f)
        {
            

            transform.position = new Vector3(transform.position.x, transform.position.y - CameraMove.inGameCamSpeed * Time.deltaTime, -350f);
            if (transform.position.y > Camera.main.transform.position.y + 3.2f)
                transform.position = new Vector2(transform.position.x, Camera.main.transform.position.y + 3.2f);
            if (!CameraMove.boost1 && !CameraMove.boost2)
            {
                gameObject.GetComponent<CapsuleCollider2D>().enabled = (true);
                CameraMove.boost3 = false;
            }
        }

        if (cursorPos.y < Camera.main.transform.position.y - 2.8f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (CameraMove.inGameCamSpeed - 1f) * Time.deltaTime, -350f);
            if (transform.position.y < Camera.main.transform.position.y - 2.8f)
                transform.position = new Vector2(transform.position.x, Camera.main.transform.position.y - 2.8f);

            
        }
        if (cursorPos.y > Camera.main.transform.position.y - 3.8f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - CameraMove.inGameCamSpeed * Time.deltaTime,-350f);
            if (!CameraMove.boost1 && !CameraMove.boost2)
            {
                gameObject.GetComponent<CapsuleCollider2D>().enabled = (true);
                CameraMove.boost3 = false;
            }
        }

        

        if (cursorPos.y < Camera.main.transform.position.y - 3.8f)
        {
            if (!CameraMove.boost1 && !CameraMove.boost2 && inGameBoostTime>0f)
            {
                inGameBoostTime -= Time.deltaTime;
                tekst.GetComponent<Text>().text = "" + (int)(inGameBoostTime*10);
                gameObject.GetComponent<CapsuleCollider2D>().enabled = (false);
                CameraMove.boost3 = true;
            }
            if(!CameraMove.boost1 && !CameraMove.boost2 && inGameBoostTime <=0f )
            {
                gameObject.GetComponent<CapsuleCollider2D>().enabled = (true);
                CameraMove.boost3 = false;
            }
            }






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
        if (CameraMove.brojZakacenihRibica < CameraMove.brojMaxZakacenihUIgri)
        transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f * Time.deltaTime, -350f);
        else
            transform.position = new Vector3(transform.position.x, transform.position.y + CameraMove.camspeed1 * Time.deltaTime, -350f);
    }
    
}
