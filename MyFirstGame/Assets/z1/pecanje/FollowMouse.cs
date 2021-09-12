using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
    public static float moveSpeed = 0.007f;
    public static float boostTime,inGameBoostTime;
    public bool uslov;
    public int brojObicnih, brojStruja, brojUkupnih;
    public float yKoordinata = 0f;
    public GameObject boostPanel,fuelIcon,rope;
    public Text tekst;
    public Sprite kuka1, kuka2, kuka3, kuka4, kuka5, kuka6, kuka7;
    private void Awake()
    {
        Application.targetFrameRate = 300;
    }
    private void Start()
    {


        if (BuyHook.hook1)
        {
            GetComponent<SpriteRenderer>().sprite = kuka2;
            rope.transform.position = new Vector3(rope.transform.position.x , rope.transform.position.y-0.05f, rope.transform.position.z);

        }
        else if (BuyHook.hook2)
        {
            GetComponent<SpriteRenderer>().sprite = kuka3;
            rope.transform.position = new Vector3(rope.transform.position.x - 0.04f, rope.transform.position.y - 0.03f, rope.transform.position.z);
        }
        else if (BuyHook.hook3)
        {
            GetComponent<SpriteRenderer>().sprite = kuka4;
            rope.transform.position = new Vector3(rope.transform.position.x - 0.09f, rope.transform.position.y-0.01f, rope.transform.position.z);
    
        }
        else if (BuyHook.hook4)
        {
            GetComponent<SpriteRenderer>().sprite = kuka5;
            rope.transform.position = new Vector3(rope.transform.position.x - 0.075f, rope.transform.position.y - 0.01f, rope.transform.position.z);

        }
        else if (BuyHook.hook5)
        {
            GetComponent<SpriteRenderer>().sprite = kuka6;
            rope.transform.position = new Vector3(rope.transform.position.x - 0.09f, rope.transform.position.y - 0.01f, rope.transform.position.z);
        }
        else if (BuyHook.hook6)
        {
            GetComponent<SpriteRenderer>().sprite = kuka7;
            rope.transform.position = new Vector3(rope.transform.position.x - 0.09f, rope.transform.position.y - 0.01f, rope.transform.position.z);

        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = kuka1;
       
          
        }


        inGameBoostTime = boostTime;
        if (boostTime < 0.01f)
            fuelIcon.SetActive(false);
        tekst.GetComponent<Text>().text = "" + (int)(inGameBoostTime * 10);

    }

    private void FixedUpdate()
    {
        if (inGameBoostTime < 0.01f)
        {
            boostPanel.SetActive(false);
        }
        uslov = CameraMove.uslovVracanja;

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
            if(CameraMove.brojZakacenihRibica >= CameraMove.brojMaxZakacenihUIgri)
            GetComponent<CapsuleCollider2D>().enabled = false;
            else
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
        if(mousePosition.y<Camera.main.transform.position.y - 2.8f)
            mousePosition = new Vector2(mousePosition.x, Camera.main.transform.position.y - 2.8f);

        transform.position= Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        

        

     
        
            transform.position = new Vector3(transform.position.x, transform.position.y - CameraMove.inGameCamSpeed * Time.deltaTime, -350f);
           

            
        
        if (cursorPos.y > Camera.main.transform.position.y - 3.8f)
        {
           
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
        if (Camera.main.transform.position.y > 1f)
            Destroy(gameObject);

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (cursorPos.y < 0)
            yKoordinata = cursorPos.y;
        else
            yKoordinata = -1;
        Vector2 mousePosition = new Vector2(cursorPos.x, yKoordinata);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed*2f);

        if(Camera.main.transform.position.y<0)
        if (CameraMove.brojZakacenihRibica < CameraMove.brojMaxZakacenihUIgri)
        transform.position = new Vector3(transform.position.x, transform.position.y + 1.75f * Time.deltaTime, -350f);
        else
            transform.position = new Vector3(transform.position.x, transform.position.y + CameraMove.camspeed1 * Time.deltaTime, -350f);
    }
    
}
