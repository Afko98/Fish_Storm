using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ispaliRibice : MonoBehaviour
{
    public GameObject[] ribaNiz,ribaNizPomocni;
    public List<GameObject> ribaNiz1,ribaNiz2,ribaNiz3;
    bool uslov1 = false,uslov4=false, uslov2 = false, uslov3 = false;
    TimeSpan maxVrijeme = new TimeSpan(0, 0, 2);
    DateTime startTime;


    public void IspaliRibice()
    {
        
            ribaNiz = GameObject.FindGameObjectsWithTag("uhvacena");

        if (!uslov4)
        {
            for(int i = 0; i < ribaNiz.Length; i++)
            {
                if (i < ribaNiz.Length / 3)
                    ribaNiz1.Add(ribaNiz[i]);
                else if(i<2*ribaNiz.Length/3)
                    ribaNiz2.Add(ribaNiz[i]);
                else
                    ribaNiz3.Add(ribaNiz[i]);
            }
            for (int i = 0; i < ribaNiz.Length; i++)
                ribaNiz[i].GetComponent<BoxCollider2D>().enabled = true;
            uslov4 = true;
        }
        
            
            
        if (!uslov1)
            for (int i = 0; i < ribaNiz1.Count; i++)
            {

                
                    ribaNiz1[i].GetComponent<Rigidbody2D>().velocity = new Vector3(UnityEngine.Random.Range(0f, 900f) / 100f - 4.5f, UnityEngine.Random.Range(35f, 130f) / 25f + 5.2f, 0f);
                    ribaNiz1[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz1[i].GetComponent<Rigidbody2D>().drag = 0.2f;
                    ribaNiz1[i].GetComponent<Rigidbody2D>().rotation = UnityEngine.Random.Range(-180f, 180f);
                if(ribaNiz1[i].transform.position.y==-11)
                    ribaNiz1[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg * 1.28f, uhvatiRibu.dmg * 1.1f);
                else
                    ribaNiz1[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                uslov1 = true;

                startTime = DateTime.UtcNow;
            }
            if (DateTime.UtcNow-startTime>maxVrijeme && !uslov2)
            for (int i = 0; i < ribaNiz2.Count; i++)
            {


               
                    ribaNiz2[i].GetComponent<Rigidbody2D>().velocity = new Vector3(UnityEngine.Random.Range(0f, 900f) / 100f - 4.5f, UnityEngine.Random.Range(35f, 140f) / 25f + 5.7f, 0f);
                    ribaNiz2[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz2[i].GetComponent<Rigidbody2D>().drag = 0.2f;
                    ribaNiz2[i].GetComponent<Rigidbody2D>().rotation = UnityEngine.Random.Range(-180f, 180f);
                if (ribaNiz2[i].transform.position.y == -11)
                    ribaNiz2[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg * 1.28f, uhvatiRibu.dmg * 1.1f);
                ribaNiz2[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                uslov2 = true;

                startTime = DateTime.UtcNow;
            }
            if (DateTime.UtcNow - startTime > maxVrijeme && !uslov3 )
            for (int i = 0; i < ribaNiz3.Count; i++)
            {


                    ribaNiz3[i].GetComponent<Rigidbody2D>().velocity = new Vector3(UnityEngine.Random.Range(0f, 900f) / 100f - 4.5f, UnityEngine.Random.Range(35f, 150f) / 25f + 6.2f, 0f);
                    ribaNiz3[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz3[i].GetComponent<Rigidbody2D>().drag = 0.2f;
                    ribaNiz3[i].GetComponent<Rigidbody2D>().rotation = UnityEngine.Random.Range(-180f, 180f);
                if (ribaNiz3[i].transform.position.y == -11)
                    ribaNiz3[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg * 1.28f, uhvatiRibu.dmg * 1.1f);
                else
                    ribaNiz3[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                uslov3 = true;
                   
                
            }
       




    }

    private void Update()
    {
        ribaNizPomocni = GameObject.FindGameObjectsWithTag("uhvacena");
        for (int i = 0; i < ribaNiz.Length; i++)
        {
            if (ribaNizPomocni[i].transform.position.x > 2.6f)
            {
                ribaNizPomocni[i].GetComponent<Rigidbody2D>().velocity = new Vector3(-ribaNizPomocni[i].GetComponent<Rigidbody2D>().velocity.x, ribaNizPomocni[i].GetComponent<Rigidbody2D>().velocity.y, 0f);
                ribaNizPomocni[i].transform.position = new Vector3(ribaNizPomocni[i].transform.position.x - 0.15f, ribaNizPomocni[i].transform.position.y, ribaNizPomocni[i].transform.position.z);
            }
            if (ribaNizPomocni[i].transform.position.x < -2.6f)
            {
                ribaNizPomocni[i].GetComponent<Rigidbody2D>().velocity = new Vector3(-ribaNizPomocni[i].GetComponent<Rigidbody2D>().velocity.x, ribaNizPomocni[i].GetComponent<Rigidbody2D>().velocity.y, 0f);
                ribaNizPomocni[i].transform.position = new Vector3(ribaNizPomocni[i].transform.position.x + 0.15f, ribaNizPomocni[i].transform.position.y, ribaNizPomocni[i].transform.position.z);
            }
        }
    }

   

}
