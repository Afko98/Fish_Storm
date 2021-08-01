
using UnityEngine;

public class spawnMjehurici : MonoBehaviour
{



    public Vector3 pos2 = Camera.main.transform.position;
    public GameObject stranaKlon, sredinaKlon, linijaKlon, strana, sredina, linija,bomba,bombaMid,bitePower,boostPower,bulletPower;
    int p = 0;
    int p1 = 45;
    int p2 = 73;
    int p3 = 122;

    void Update()
    { 
        Vector3 pos1 = Camera.main.transform.position;
        foreach(var c in GameObject.FindGameObjectsWithTag("bomb"))
        {
            c.transform.position = new Vector2(c.transform.position.x + 0.0008f*Mathf.Cos(p/200f) , c.transform.position.y + 0.0011f * Mathf.Sin(p/400f));
        }
        foreach (var c in GameObject.FindGameObjectsWithTag("boostPower"))
        {
            c.transform.position = new Vector2(c.transform.position.x + 0.003f * Mathf.Cos(p1 / 550f), c.transform.position.y + 0.001f * Mathf.Sin(p2 / 70f));
        }
        foreach (var c in GameObject.FindGameObjectsWithTag("bitePower"))
        {
            c.transform.position = new Vector2(c.transform.position.x + 0.0035f * Mathf.Cos(p2 / 520f), c.transform.position.y + 0.001f * Mathf.Sin(p3 / 60f));
        }
        foreach (var c in GameObject.FindGameObjectsWithTag("bulletPower"))
        {
            c.transform.position = new Vector2(c.transform.position.x + 0.004f * Mathf.Cos(p3 / 500f), c.transform.position.y + 0.001f * Mathf.Sin(p1 / 50f));
        }
        p++;
        p1++;
        p2++;
        p3++;
        if (pos1.y < pos2.y)
        {
            for (int i = 0; i < Random.Range(-0.5f, 2f); i++)
            {
                int k = Random.Range(0, 2);
                if (k * 3.2f - 1.6f > 0)
                    stranaKlon = Instantiate(strana, new Vector2(k * 3.2f - 1.6f, pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), transform.rotation * Quaternion.Euler(0f, 1f * 180f, 0f));
                else
                    stranaKlon = Instantiate(strana, new Vector2(k * 3.2f - 1.6f, pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), transform.rotation * Quaternion.Euler(0f, 0f * 180f, 0f));

                
            }

            ////////////////////////////////////
            for(int i = 0; i < Random.Range(-0.7f, 1.5f); i++)
            {
                linijaKlon = Instantiate(linija, new Vector2(Random.Range(0f, 10f) * 0.44f - 2.2f,pos2.y-5.12f-Random.Range(0f,50f)/6f),Quaternion.identity);
            }
            ////////////////////////////////////
            ///
            for (int i = 0; i < Random.Range(-0.7f, 1.6f); i++)
            {
                linijaKlon = Instantiate(sredina, new Vector2(Random.Range(0f, 10f) * 0.44f - 2.2f, pos2.y - 8.12f - Random.Range(0f, 50f) / 5f), Quaternion.identity);
            }
            ////////////////////////////////////
            ///
            for (int i = 0; i < Random.Range(-6f, 2f); i++)
            {
                int k = Random.Range(0, 2);
                if (k > 0)
                    stranaKlon = Instantiate(bomba, new Vector2(k * 3.2f - 1.28f+Random.Range(0f,0.43f), pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), transform.rotation * Quaternion.Euler(0f, 1f * 180f, 0f));
                else
                    stranaKlon = Instantiate(bomba, new Vector2(k * 3.2f - 2.38f + Random.Range(0f,0.43f), pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), transform.rotation * Quaternion.Euler(0f, 0f * 180f, 0f));

            }
            ////////////////////////////////////
            ///
            if(pos1.y<-160f)
            for (int i = 0; i < Random.Range(-6f, 2f); i++)
            {
                    stranaKlon = Instantiate(bombaMid, new Vector2(Random.Range(-2.7f, 2.5f), pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), Quaternion.identity);

            }
            ///////////////////////////////////
            ///
            if (pos1.y < -70f)
            {
                for (int i = 0; i < Random.Range(-16f, 0.99f); i++)
                {
                    stranaKlon = Instantiate(bitePower, new Vector2(Random.Range(-1f, 1f), pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), Quaternion.identity);

                }
                for (int i = 0; i < Random.Range(-12f, 0.99f); i++)
                {
                    stranaKlon = Instantiate(bulletPower, new Vector2(Random.Range(-1f, 1f), pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), Quaternion.identity);

                }
                for (int i = 0; i < Random.Range(-9f, 0.99f); i++)
                {
                    stranaKlon = Instantiate(boostPower, new Vector2(Random.Range(-1f, 1f), pos2.y - 5.12f - Random.Range(0f, 50f) / 6f), Quaternion.identity);

                }
            }
            ///////////////////////////////////

            pos2.y -= 5.12f;
        }

    }
}
