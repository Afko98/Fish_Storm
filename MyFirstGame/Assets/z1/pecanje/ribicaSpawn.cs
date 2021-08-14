
using UnityEngine;

public class ribicaSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject ribaObicna, ribaStruja, ribaJelly, ribaRavna,ribaAjkula,ribaZlatna;

    public Vector3 pos2 = Camera.main.transform.position;
    public GameObject obicnaKlon,strujaKlon,jellyKlon,ravnaKlon,ajkulaKlon,blago,blagoKlon;
    public int brojacObicna = 0,brojacStruja=0;


    private void Start()
    {

        float i = Random.Range(-1f, 3.2f);
        if(i>=3)
            blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 150f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
           if(i>=2)
        blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 190f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
        if(i>=1)
        blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 230f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
        
        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-2.40f, 2.40f), pos2.y - 1.12f - Random.Range(0f, 4f),-1f), transform.rotation * Quaternion.Euler(0f, 0f, 0f)) as GameObject;
        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-2.40f, 2.40f), pos2.y - 1.12f - Random.Range(0f, 4f),-1f), transform.rotation * Quaternion.Euler(0f, 0f, 0f)) as GameObject;
        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-2.40f, 2.40f), pos2.y - 1.12f - Random.Range(0f, 4f),-1f), transform.rotation * Quaternion.Euler(0f, 0f, 0f)) as GameObject;
        obicnaKlon.name = "ribaObicna" + brojacObicna;
        brojacObicna++;
    }
    // Update is called once per frame
    void Update()
    {  
        Vector3 pos1 = Camera.main.transform.position;
        
        
        
        if (pos1.y<pos2.y)
        {
            
                if(pos1.y>-18f)
                for (int i = 0; i < Random.Range(8f, 27f); i++)
                {
                    obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f)/7f,-1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    obicnaKlon.name = "ribaObicna" + brojacObicna;
                    obicnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                    brojacObicna++;
                }
                else if(pos1.y>-35)
                    for (int i = 0; i < Random.Range(8f, 20f); i++)
                    {
                        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f)/10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                        obicnaKlon.name = "ribaObicna" + brojacObicna;
                    obicnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                    brojacObicna++;
                    }
                else 
                for (int i = 0; i < Random.Range(3f, 10f); i++)
                {
                    obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    obicnaKlon.name = "ribaObicna" + brojacObicna;
                    obicnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                    brojacObicna++;
                }

                ///////////////////////////////////////////////////////////////
            if (pos1.y < -30f && pos1.y>-65f)
            {
                for (int i = 0; i < Random.Range(4f, 11f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                    brojacStruja++;
                }
            }
            else if ((pos1.y <= -65 && pos1.y>-95)|| (pos1.y < -20 && pos1.y >= -30))
            {
                for (int i = 0; i < Random.Range(1f, 6f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y -5.12f - Random.Range(0f, 70f) / 7f, -3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                    brojacStruja++;
                }
            }
            else if (pos1.y < -95f)
                for (int i = 0; i < Random.Range(-2f, 2f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                    brojacStruja++;
                }
            else if (pos1.y < -250f)
                for (int i = 0; i < Random.Range(-3.5f, 1.6f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                    brojacStruja++;
                }
            ///////////////////////////////

            if (pos1.y < -80f && pos1.y > -120f)
            {
                for (int i = 0; i < Random.Range(2f, 6f); i++)
                {
                    jellyKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    jellyKlon.name = "ribaJelly" + brojacStruja;
                    jellyKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if(pos1.y <= -120f && pos1.y>-155f)
                for (int i = 0; i < Random.Range(0f, 4f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if(pos1.y<-155f || (pos1.y<-65f && pos1.y>=-80))
                for (int i = 0; i < Random.Range(-2f, 2f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if (pos1.y < -270f )
                for (int i = 0; i < Random.Range(-3f, 2f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            /////////////////////////////////////////

            if (pos1.y < -130f && pos1.y > -170f)
            {
                for (int i = 0; i < Random.Range(2f, 8f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -15f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ravnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if (pos1.y <= -170f && pos1.y > -210f)
                for (int i = 0; i < Random.Range(0f, 4f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -15f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ravnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if (pos1.y < -210f || (pos1.y < -110 && pos1.y >= -130))
                for (int i = 0; i < Random.Range(-2f, 3f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -15f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ravnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if (pos1.y < -260f )
                for (int i = 0; i < Random.Range(-3f, 2f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -15f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ravnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }

            //////////////////////////////////
            if (pos1.y < -180f && pos1.y > -220f)
            {
                for (int i = 0; i < Random.Range(-1f, 3f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -28f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if (pos1.y <= -220f && pos1.y > -250f)
                for (int i = 0; i < Random.Range(-2f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -28f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if (pos1.y <= -250f || (pos1.y < -160f && pos1.y >= -180f))
                for (int i = 0; i < Random.Range(-3f, 1f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -28f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            //////////////////////////////////
            

            if (pos1.y < -230f)
            {
                for (int i = 0; i < Random.Range(-10f, 0.9f); i++)
                {
                    ajkulaKlon = Instantiate(ribaZlatna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -100f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }
            }

            //////////////////////////////////

            pos2.y-=5.12f;
        }
    }
}
