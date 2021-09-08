using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giftScript : MonoBehaviour
{
    static public int brGift = 100;
    public GameObject panel, w1,w2, w3, w4, w5, w6, w7, w8, w9, w10,w11,w12,w13,w14,w15,w16,coin,r1,r2,r3,r4,r5,r6;
    float randBr;
    public Text tekst,letsFish;
    private void Start()
    {
        tekst.GetComponent<Text>().text = "" + brGift;
        w1.SetActive(false);
        w2.SetActive(false);
        w3.SetActive(false);
        w4.SetActive(false);
        w5.SetActive(false);
        w6.SetActive(false);
        w7.SetActive(false);
        w8.SetActive(false);
        w9.SetActive(false);
        w10.SetActive(false);
        w11.SetActive(false);
        w12.SetActive(false);
        w13.SetActive(false);
        w14.SetActive(false);
        w15.SetActive(false);
        w16.SetActive(false);
        panel.SetActive(false);
        


    }
    public void panelUp()
    {
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayGiftOpen();

        if (brGift < 1)
            return;

        
        letsFish.GetComponent<Text>().text = "";
        brGift--;
        tekst.GetComponent<Text>().text = "" + brGift;
        panel.SetActive(true);
        randBr=Random.Range(0f, 100f);
      

        if (randBr < 0.1f)
        {
            w1.SetActive(true);
            pucajRibu.brojMetaka++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 10; i++)
            {
               var a = Instantiate(r1,new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
               var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f,-5.2f, 0f), Quaternion.identity);
               var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f,-5.2f, 0f), Quaternion.identity);
               var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f,-5.2f, 0f), Quaternion.identity);
               var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f,-5.2f, 0f), Quaternion.identity);
               var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f,-5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f); 
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f); 
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f); 
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f); 
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                
            }
        }
        if(randBr>=0.1f && randBr <0.433f)
        {
            w2.SetActive(true);
            spawnAkvariji.brDiver++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 8; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 0.433f && randBr <0.76f)
        {
            w12.SetActive(true);
            spawnAkvariji.brBob++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 8; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 0.76f && randBr < 1.09f)
        {
            w13.SetActive(true);
            spawnAkvariji.brPatrik++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 8; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 1.09f && randBr < 1.43f)
        {
            w14.SetActive(true);
            spawnAkvariji.brIgla++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 8; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >=1.43f && randBr < 1.765f)
        {
            w15.SetActive(true);
            spawnAkvariji.brObicnaZelena++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 8; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 1.765f && randBr < 2.098f)
        {
            w16.SetActive(true);
            spawnAkvariji.brNemo++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 8; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 2.098f && randBr < 2.431f)
        {
            w11.SetActive(true);
            spawnAkvariji.brPodmornica++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 8; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 2.431f && randBr < 2.764f)
        {
            w3.SetActive(true);
            spawnAkvariji.brZlato++;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            for (int i = 0; i < 8; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 2.764f && randBr < 3.3f)
        {
            w4.SetActive(true);
            currency.allCurrency += 2000;
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayUnique();
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            for (int i = 0; i < 6; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 3.3f && randBr < 5.3f)
        {
            w5.SetActive(true);
            currency.allCurrency += 1000;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            for (int i = 0; i < 3; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >=5.3f && randBr < 8.6f)
        {
            w6.SetActive(true);
            currency.allCurrency += 500;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            for (int i = 0; i < 2; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 8.6f && randBr < 13.6f)
        {
            w7.SetActive(true);
            currency.allCurrency += 200;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            for (int i = 0; i < 1; i++)
            {
                var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
                var f = Instantiate(r6, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);

                a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                d.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
                d.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                e.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
                e.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                f.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
                f.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            }
        }
        if (randBr >= 13.6f && randBr < 20f)
        {
            w8.SetActive(true);
            currency.allCurrency += 100;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            
            

            a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
            a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            b.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-60f, 100f) / 25f + 5.2f, 0f);
            b.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
            c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            
            
        }
        if (randBr >= 20f && randBr < 40f)
        {
            w9.SetActive(true);
            currency.allCurrency += 50;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            
            var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            

            a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
            a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
         
            c.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-40f, 100f) / 25f + 5.2f, 0f);
            c.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            
        }
        if (randBr >= 40f && randBr < 100f)
        {
            w10.SetActive(true);
            currency.allCurrency += 10;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            

            a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
            a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            

        }
        SaveSystem.SavePlayer();
    }
    public void panelDonw()
    {
        w1.SetActive(false);
        w2.SetActive(false);
        w3.SetActive(false);
        w4.SetActive(false);
        w5.SetActive(false);
        w6.SetActive(false);
        w7.SetActive(false);
        w8.SetActive(false);
        w9.SetActive(false);
        w10.SetActive(false);
        w11.SetActive(false);
        w12.SetActive(false);
        w13.SetActive(false);
        w14.SetActive(false);
        w15.SetActive(false);
        w16.SetActive(false);
        panel.SetActive(false);
        letsFish.GetComponent<Text>().text = "LET'S\nFISH";
    }
    
}
///ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(0f, 100f) / 25f + 5.2f, 0f);
///ribaNiz[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);