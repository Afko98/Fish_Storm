using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ispaliRibice : MonoBehaviour
{
    public GameObject[] ribaNiz;
    public List<GameObject> ribaNiz1,ribaNiz2,ribaNiz3;
    bool uslov1 = false,uslov4=false, uslov2 = false, uslov3 = false;

    
    
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

                
                    ribaNiz1[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(35f, 115f) / 25f + 5.2f, 0f);
                    ribaNiz1[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz1[i].GetComponent<Rigidbody2D>().drag = 0.18f;
                    ribaNiz1[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                if(ribaNiz1[i].transform.position.y==-11)
                    ribaNiz1[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg * 1.28f, uhvatiRibu.dmg * 1.1f);
                else
                    ribaNiz1[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                uslov1 = true;
                

                }
            if (Camera.main.transform.position.y > 6f && !uslov2)
            for (int i = 0; i < ribaNiz2.Count; i++)
            {


               
                    ribaNiz2[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(35f, 115f) / 25f + 5.7f, 0f);
                    ribaNiz2[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz2[i].GetComponent<Rigidbody2D>().drag = 0.18f;
                    ribaNiz2[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                if (ribaNiz2[i].transform.position.y == -11)
                    ribaNiz2[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg * 1.28f, uhvatiRibu.dmg * 1.1f);
                ribaNiz2[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                uslov2 = true;
                    
                
            }
            if (Camera.main.transform.position.y > 7f && !uslov3 )
            for (int i = 0; i < ribaNiz3.Count; i++)
            {


                    ribaNiz3[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(35f, 115f) / 25f + 6.2f, 0f);
                    ribaNiz3[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz3[i].GetComponent<Rigidbody2D>().drag = 0.18f;
                    ribaNiz3[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                if (ribaNiz3[i].transform.position.y == -11)
                    ribaNiz3[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg * 1.28f, uhvatiRibu.dmg * 1.1f);
                else
                    ribaNiz3[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                uslov3 = true;
                   
                
            }
       




    }

    private void Update()
    {
        for (int i = 0; i < ribaNiz.Length; i++)
        {
            if (ribaNiz[i].transform.position.x > 2.6f)
            {
                ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(-ribaNiz[i].GetComponent<Rigidbody2D>().velocity.x, ribaNiz[i].GetComponent<Rigidbody2D>().velocity.y, 0f);
                ribaNiz[i].transform.position = new Vector3(ribaNiz[i].transform.position.x - 0.15f, ribaNiz[i].transform.position.y, ribaNiz[i].transform.position.z);
            }
            if (ribaNiz[i].transform.position.x < -2.6f)
            {
                ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(-ribaNiz[i].GetComponent<Rigidbody2D>().velocity.x, ribaNiz[i].GetComponent<Rigidbody2D>().velocity.y, 0f);
                ribaNiz[i].transform.position = new Vector3(ribaNiz[i].transform.position.x + 0.15f, ribaNiz[i].transform.position.y, ribaNiz[i].transform.position.z);
            }
        }
    }

   

}
