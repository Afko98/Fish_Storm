using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float camspeed = 0.75f,camspeed1;
    public int brojZakacenihRibica=0;
    public bool uslovVracanja = false;
    public static float uze=10f;
    public static int brojMaxZakacenihRibica=5;




    // Update is called once per frame
    public void Update()
    {
        brojZakacenihRibica = GameObject.FindGameObjectsWithTag("uhvacena").Length;

        
       

        if (transform.position.y < -uze || brojZakacenihRibica >= brojMaxZakacenihRibica)
        {
            uslovVracanja = true;
        }
        if (uslovVracanja)
        {
            PremaGore();
            camspeed1 = camspeed + 3.5f;
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
        else
        {
            //aktiviraj dugme za kraj igre - deaktiviraj ga na pocetku uvijek (start(){});

        }
        
        
    }
    public void PremaDole()
    {
        Vector3 pos1 = transform.position;
       
      
            camspeed += Time.deltaTime / 130;
        pos1.y -= Time.deltaTime * camspeed;
        transform.position = pos1;

    }

}
