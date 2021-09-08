using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update

    
    public static float camspeed = 0.9f,camspeed1;
    public static int brojZakacenihRibica=0;
    static public bool uslovVracanja = false;
    public static float uze=25f;
    public static int brojMaxZakacenihRibica=5;
    public static int brojMaxZakacenihUIgri;
    public static int totalTravel=0;
    public GameObject startDugme,chestDelete;
    public static bool boost1 = false,boost2=false,boost3=false;
    static public float pomocnaSpeed,inGameCamSpeed;
    public GameObject boostPanel;
    bool uslov11 = false;
    public Text text50, text150;

   public void Start()
    {
        inGameCamSpeed = camspeed;
        boost1 = false;
        boost2 = false;
        boost3 = false;
        Time.timeScale = 0;
        brojMaxZakacenihUIgri = brojMaxZakacenihRibica;
        uslovVracanja = false;
    }

    public void kupiBoostI()
    {
        if (currency.allCurrency >= 50 && !boost1 && !boost2)
        {
            boost1 = true;
            text50.GetComponent<Text>().text = ":)";
            currency.allCurrency -= 50;
        }
    }
    public void kupiBoostII()
    {
        if (currency.allCurrency >= 250 && !boost1 && !boost2)
        {
            boost2 = true;
            text150.GetComponent<Text>().text = ":)";
            currency.allCurrency -= 250;
        }
    }

    public void Kreni()
    {
        Time.timeScale = 1;
        startDugme.SetActive(false);
    }
    public void FixedUpdate()
    {
        
        brojZakacenihRibica = GameObject.FindGameObjectsWithTag("uhvacena").Length;

            if (transform.position.y < -49f)
                achivments.upTo50 = true;
            if (transform.position.y < -99f)
                achivments.upTo100 = true;
            if (transform.position.y < -199f)
                achivments.upTo200 = true;
            if (transform.position.y < -49f && brojZakacenihRibica == 0)
                achivments.upTo50wcf = true;
            if (transform.position.y < -99f && brojZakacenihRibica == 0)
                achivments.upTo100wcf = true;
            if (transform.position.y < -199f && brojZakacenihRibica == 0)
                achivments.upTo200wcf = true;
       

        if ((transform.position.y < -uze || brojZakacenihRibica >= brojMaxZakacenihUIgri) && !uslovVracanja)
        {
            totalTravel -= (int)transform.position.y;
            if (totalTravel > 9999)
                achivments.travel10000 = true;

            

            uslovVracanja = true;
        }
        if (uslovVracanja)
        {
            PremaGore();
            camspeed1 = inGameCamSpeed + 15.7f;
        }
        else if (!uslovVracanja)
            PremaDole();
            
        
    }

    

    public void PremaGore()
    {
        boostPanel.SetActive(false);
        if(transform.position.y<-5f)
        chestDelete.transform.position = new Vector2(chestDelete.transform.position.x, transform.position.y - 9f);
        else
            chestDelete.transform.position = new Vector2(chestDelete.transform.position.x, transform.position.y - 25f);
        if (brojZakacenihRibica < brojMaxZakacenihUIgri && transform.position.y < 2)
        {
            Vector3 pos1 = transform.position;
            
            pos1.y += Time.deltaTime * (1.75f);
            transform.position = pos1;
        }

        else if (transform.position.y <= 7f)
        {
            Vector3 pos1 = transform.position;
            pos1.y += Time.deltaTime * camspeed1;
            transform.position = pos1;
        }
        else if(transform.position.y<=10f)
        {
            camspeed1 = 0.6f;
            Vector3 pos1 = transform.position;
            pos1.y += Time.deltaTime * camspeed1;
            transform.position = pos1;
        }
        
        
        
    }
    public void PremaDole()
    {
        Vector3 pos1 = transform.position;
        if (boost3)
            inGameCamSpeed = 6f;

        else if (!boost1 && !boost2)
        {
            if (transform.position.y > -100f)
                inGameCamSpeed = 1.7f;
            else if (transform.position.y > -200f)
                inGameCamSpeed = 2f;
            else
                inGameCamSpeed = 2.2f;
        }
        else if (boost1)
        {
            inGameCamSpeed = 8f;
            if (transform.position.y < -49f)
            {
                boost1 = false;
            }
        }
        else if (boost2)
        {
            inGameCamSpeed = 13f;
            if (transform.position.y < -149f)
            {
                inGameCamSpeed = 1.7f;
                boost2 = false;
            }
        }

        
        
        
            
        pos1.y -= Time.deltaTime * inGameCamSpeed;
        transform.position = pos1;

    }

}
