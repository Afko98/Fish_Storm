using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giftScript : MonoBehaviour
{
    static int brGift = 3;
    public GameObject panel, w1,w2, w3, w4, w5, w6, w7, w8, w9, w10,coin,r1,r2,r3,r4,r5,r6;
    float randBr;
    public Text tekst;
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
        panel.SetActive(false);

      
    }
    public void panelUp()
    {
        if (brGift < 1)
            return;
        brGift--;
        tekst.GetComponent<Text>().text = "" + brGift;
        panel.SetActive(true);
        randBr=Random.Range(0f, 100f);
        Debug.Log(randBr);
        if (randBr < 0.05f)
        {
            w1.SetActive(true);
            pucajRibu.brojMetaka++;
            for(int i = 0; i < 30; i++)
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
        if(randBr>=0.05f && randBr <0.3f)
        {
            w2.SetActive(true);
            spawnAkvariji.brDiver++;
            for (int i = 0; i < 25; i++)
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
        if (randBr >= 0.3f && randBr < 0.55f)
        {
            w3.SetActive(true);
            spawnAkvariji.brZlato++;
            for (int i = 0; i < 20; i++)
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
        if (randBr >= 0.55f && randBr < 0.85f)
        {
            w4.SetActive(true);
            currency.allCurrency += 2000;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            for (int i = 0; i < 12; i++)
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
        if (randBr >= 0.85f && randBr < 1.6f)
        {
            w5.SetActive(true);
            currency.allCurrency += 1000;
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
        if (randBr >=1.6f && randBr < 1.5f)
        {
            w6.SetActive(true);
            currency.allCurrency += 500;
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
        if (randBr >= 1.5f && randBr < 7f)
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
        if (randBr >= 7f && randBr < 26f)
        {
            w8.SetActive(true);
            currency.allCurrency += 100;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            var b = Instantiate(r2, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            var c = Instantiate(r3, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            var d = Instantiate(r4, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            var e = Instantiate(r5, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            

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
            
        }
        if (randBr >= 26f && randBr < 40f)
        {
            w9.SetActive(true);
            currency.allCurrency += 50;
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
        if (randBr >= 40f && randBr < 100f)
        {
            w10.SetActive(true);
            currency.allCurrency += 10;
            coin.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            var a = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);
            

            a.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
            a.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);

            var k = Instantiate(r1, new Vector3(Random.Range(0f, 300f) / 100f - 1.5f, -5.2f, 0f), Quaternion.identity);


            k.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 200f) / 100f - 1f, Random.Range(-50f, 100f) / 25f + 5.2f, 0f);
            k.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);


        }
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
        panel.SetActive(false);
    }
    
}
///ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(0f, 100f) / 25f + 5.2f, 0f);
///ribaNiz[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);