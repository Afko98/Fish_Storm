
using UnityEngine;

public class spawnMjehurici : MonoBehaviour
{



    public Vector3 pos2 = Camera.main.transform.position;
    public GameObject stranaKlon, sredinaKlon, linijaKlon, strana, sredina, linija;


    void Update()
    {
        Vector3 pos1 = Camera.main.transform.position;

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

            pos2.y -= 5.12f;
        }

    }
}
