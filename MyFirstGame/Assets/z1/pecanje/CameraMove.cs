using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float camspeed = 0.8f,camspeed1;
    public static int brojZakacenihRibica=0;
    public bool uslovVracanja = false;
    public static float uze=20f;
    public static int brojMaxZakacenihRibica=5;
    public static int brojMaxZakacenihUIgri;

   public void Start()
    {
        brojMaxZakacenihUIgri = brojMaxZakacenihRibica;
    }

    // Update is called once per frame
    public void Update()
    {
        brojZakacenihRibica = GameObject.FindGameObjectsWithTag("uhvacena").Length;

        
       

        if (transform.position.y < -uze || brojZakacenihRibica >= brojMaxZakacenihUIgri)
        {
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
            camspeed1 = 0.75f;
            Vector3 pos1 = transform.position;
            pos1.y += Time.deltaTime * camspeed1;
            transform.position = pos1;
        }
        
        
        
    }
    public void PremaDole()
    {
        Vector3 pos1 = transform.position;
       
      
            camspeed += Time.deltaTime / 90;
        if (camspeed > 2f)
            camspeed = 2f;
        pos1.y -= Time.deltaTime * camspeed;
        transform.position = pos1;

    }

}
