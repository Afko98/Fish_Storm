using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update

    
    public static float camspeed = 0.9f,camspeed1;
    public static int brojZakacenihRibica=0;
    public bool uslovVracanja = false;
    public static float uze=100f;
    public static int brojMaxZakacenihRibica=50;
    public static int brojMaxZakacenihUIgri;
    public static int totalTravel=0;
    public GameObject startDugme;
    public static bool boost1 = false,boost2=false;

   public void Start()
    {
        boost1 = false;
        boost2 = false;
        Time.timeScale = 0;
        brojMaxZakacenihUIgri = brojMaxZakacenihRibica;
    }

    public void kupiBoostI()
    {
        if (currency.allCurrency >= 50 && !boost1 && !boost2)
        {
            boost1 = true;
            currency.allCurrency -= 50;
        }
    }
    public void kupiBoostII()
    {
        if (currency.allCurrency >= 250 && !boost1 && !boost2)
        {
            boost2 = true;
            currency.allCurrency -= 250;
        }
    }

    public void Kreni()
    {
        Time.timeScale = 1;
        startDugme.SetActive(false);
    }
    public void Update()
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

            Debug.Log("..." + totalTravel); // testiraj
            

            uslovVracanja = true;
        }
        if (uslovVracanja)
        {
            PremaGore();
            camspeed1 = camspeed + 4.7f;
        }
        else if (!uslovVracanja)
            PremaDole();
            
        
    }

    

    public void PremaGore()
    {
        if (transform.position.y <= 5)
        {
            Vector3 pos1 = transform.position;
            pos1.y += Time.deltaTime * camspeed1;
            transform.position = pos1;
        }
        else if(transform.position.y<=11)
        {
            camspeed1 = 0.58f;
            Vector3 pos1 = transform.position;
            pos1.y += Time.deltaTime * camspeed1;
            transform.position = pos1;
        }
        
        
        
    }
    public void PremaDole()
    {
        Vector3 pos1 = transform.position;

        if (!boost1 && !boost2)
            camspeed += Time.deltaTime / 100;
        else if (boost1)
        {
            camspeed = 8f;
            if (transform.position.y < -49f)
            {
                camspeed = 1.27f;
                boost1 = false;
            }
        }
        else if (boost2)
        {
            camspeed = 8f;
            if (transform.position.y < -149f)
            {
                camspeed = 1.5f;
                boost2 = false;
            }
        }

        if (camspeed > 2f && !boost1 && !boost2)
            camspeed = 2f;
        pos1.y -= Time.deltaTime * camspeed;
        transform.position = pos1;

    }

}
