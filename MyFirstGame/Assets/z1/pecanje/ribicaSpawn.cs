
using UnityEngine;

public class ribicaSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject ribaObicna, ribaStruja, ribaJelly, ribaRavna,ribaAjkula,ribaIgla,ribaZlatna,ribaCrvena,smece,kutija,gift,ribaNemo,ribaSkrga,ribaPatrik,ribaObicnaZelena;

    public Vector3 pos2 = Camera.main.transform.position;
    public GameObject obicnaKlon,strujaKlon,jellyKlon,ravnaKlon,riba,ajkulaKlon,blago,blagoKlon,smeceKlon,crvenaKlon,kutijaKlon,giftKlon;

    public void KillCrate(float x,float y)
    {
        for (int i = 0; i < Random.Range(-2f, 6f); i++)  //gift
        {
            riba = Instantiate(gift, new Vector3(x,y, -11f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
            riba.tag = "uhvacena";
            riba.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 90f) / 10f - 4.5f, Random.Range(20f, 115f) / 25f +3f, 0f);
            riba.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            riba.GetComponent<Rigidbody2D>().drag = 0.18f;
            riba.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            riba.GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg * 1.28f, uhvatiRibu.dmg * 1.1f);
            

        }
        for (int i = 0; i < Random.Range(-4f, 4f); i++)
        {
            riba = Instantiate(ribaZlatna, new Vector3(x, y, -120f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
            riba.tag = "uhvacena";
            riba.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 90f) / 10f - 4.5f, Random.Range(20f, 115f) / 25f + 3f, 0f);
            riba.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            riba.GetComponent<Rigidbody2D>().drag = 0.18f;
            riba.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            riba.GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
            
        }
        for (int i = 0; i < Random.Range(-1f, 8f); i++)
        {
            riba = Instantiate(ribaNemo, new Vector3(x, y, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
            riba.tag = "uhvacena";
            riba.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 90f) / 10f - 4.5f, Random.Range(20f, 115f) / 25f + 3f, 0f);
            riba.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            riba.GetComponent<Rigidbody2D>().drag = 0.18f;
            riba.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            riba.GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
            
        }
        for (int i = 0; i < Random.Range(-2f, 6f); i++)
        {
            riba = Instantiate(ribaSkrga, new Vector3(x, y, -35f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
            riba.tag = "uhvacena";
            riba.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 90f) / 10f - 4.5f, Random.Range(20f, 115f) / 25f + 3f, 0f);
            riba.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            riba.GetComponent<Rigidbody2D>().drag = 0.18f;
            riba.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            riba.GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
            
        }
        for (int i = 0; i < Random.Range(-4f, 4f); i++)
        {
            riba = Instantiate(ribaPatrik, new Vector3(x, y, -25f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
            riba.tag = "uhvacena";
            riba.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 90f) / 10f - 4.5f, Random.Range(20f, 115f) / 25f + 3f, 0f);
            riba.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            riba.GetComponent<Rigidbody2D>().drag = 0.18f;
            riba.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            riba.GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
            
        }
        for (int i = 0; i < Random.Range(-1f, 5f); i++)
        {
            riba = Instantiate(ribaRavna, new Vector3(x, y, -18f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
            riba.tag = "uhvacena";
            riba.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 90f) / 10f - 4.5f, Random.Range(20f, 115f) / 25f + 3f, 0f);
            riba.GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            riba.GetComponent<Rigidbody2D>().drag = 0.18f;
            riba.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
            riba.GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
            
        }
 
        return;
    }

    private void Start()
    {

        float i = Random.Range(-7f, 3.2f);
        if(i>=3)
            blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 150f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
           if(i>=2)
        blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 190f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
        if(i>=1)
        blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 250f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
        
        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-2.40f, 2.40f), pos2.y - 1.12f - Random.Range(0f, 4f),-2f), transform.rotation * Quaternion.Euler(0f, 0f, 0f)) as GameObject;
        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-2.40f, 2.40f), pos2.y - 1.12f - Random.Range(0f, 4f),-2f), transform.rotation * Quaternion.Euler(0f, 0f, 0f)) as GameObject;
        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-2.40f, 2.40f), pos2.y - 1.12f - Random.Range(0f, 4f),-2f), transform.rotation * Quaternion.Euler(0f, 0f, 0f)) as GameObject;
    

    }
    // Update is called once per frame
    void Update()
    {  
        Vector3 pos1 = Camera.main.transform.position;
        
        
        ///////////////////////////////////  obicna
        if (pos1.y<pos2.y)
        {
            
                if(pos1.y>-18f)
                for (int i = 0; i < Random.Range(5f, 14f); i++)
                {
                    obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f)/7f,-2f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
              
                    obicnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                
                }
                else if(pos1.y>-35)
                    for (int i = 0; i < Random.Range(1f, 8f); i++)
                    {
                        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f)/10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -2f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                
                    obicnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                   
                    }
                else 
                for (int i = 0; i < Random.Range(-4f, 6f); i++)
                {
                    obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -2f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
        
                    obicnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                 
                }
            ///////////////////////// obicnaZelena
            if (pos1.y > -20f)
            {
                for (int i = 0; i < Random.Range(4f, 11f); i++)
                {
                    strujaKlon = Instantiate(ribaObicnaZelena, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -2f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;

                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                   
                }
            }
            else
            {
                for (int i = 0; i < Random.Range(-4f, 6f); i++)
                {
                    strujaKlon = Instantiate(ribaObicnaZelena, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -2f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;

                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                   
                }
            }
            ///////////////////////////////////////////////////////////////   struja
            if (pos1.y < -30f && pos1.y>-65f)
            {
                for (int i = 0; i < Random.Range(4f, 11f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -4f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                   
                }
            }
            else if ((pos1.y <= -65 && pos1.y>-95)|| (pos1.y < -20 && pos1.y >= -30))
            {
                for (int i = 0; i < Random.Range(1f, 6f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y -5.12f - Random.Range(0f, 70f) / 7f, -4f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                
                }
            }
            
            else if (pos1.y < -250f)
                for (int i = 0; i < Random.Range(-3.5f, 1.6f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -4f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
      
                }
            /////////////////////////// nemo

            if (pos1.y < -60f && pos1.y > -100f)
            {
                for (int i = 0; i < Random.Range(-1f, 4f); i++)
                {
                    jellyKlon = Instantiate(ribaNemo, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    jellyKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if(pos1.y<=-100f)
                for (int i = 0; i < Random.Range(-3f, 2f); i++)
                {
                    strujaKlon = Instantiate(ribaNemo, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }

            ///////////////////////////////   jelly


            if (pos1.y < -80f && pos1.y > -120f)
            {
                for (int i = 0; i < Random.Range(0f,5f); i++)
                {
                    jellyKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -10f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    jellyKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if(pos1.y <= -120f && pos1.y>-155f)
                for (int i = 0; i < Random.Range(-1f, 4f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -10f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if(pos1.y<=-155f || (pos1.y<-65f && pos1.y>=-80))
                for (int i = 0; i < Random.Range(-2f, 2f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -10f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if (pos1.y < -270f )
                for (int i = 0; i < Random.Range(-3f, 2f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -10f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            /////////////////////////////////////////  ravna

            if (pos1.y < -130f && pos1.y > -170f)
            {
                for (int i = 0; i < Random.Range(2f, 6f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -18f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ravnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if (pos1.y <= -170f && pos1.y > -210f)
                for (int i = 0; i < Random.Range(0f, 4f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -18f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ravnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if (pos1.y < -210f || (pos1.y < -110 && pos1.y >= -130))
                for (int i = 0; i < Random.Range(-2f, 3f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -18f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ravnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if (pos1.y < -260f )
                for (int i = 0; i < Random.Range(-3f, 2f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -18f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ravnaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }

            ////////////////////////////////// patrik

            if (pos1.y < -150f && pos1.y > -200f)
            {
                for (int i = 0; i < Random.Range(-2f, 3f); i++)
                {
                    ajkulaKlon = Instantiate(ribaPatrik, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -25f), Quaternion.identity) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if (pos1.y <= -200f)
                for (int i = 0; i < Random.Range(-4f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaPatrik, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -25f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }

            //////////////////////////////////     ajkula
            ///

            if (pos1.y < -180f && pos1.y > -220f)
            {
                for (int i = 0; i < Random.Range(-1f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -40f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if (pos1.y <= -220f && pos1.y > -250f)
                for (int i = 0; i < Random.Range(-2f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -40f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            else if (pos1.y <= -250f || (pos1.y < -160f && pos1.y >= -180f))
                for (int i = 0; i < Random.Range(-3f, 1f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -40f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }

            ////////////////////////////////// skrga
            ///

            if (pos1.y < -200f && pos1.y > -240f)
            {
                for (int i = 0; i < Random.Range(-2f, 3f); i++)
                {
                    ajkulaKlon = Instantiate(ribaSkrga, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -35f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if (pos1.y <= -240f)
                for (int i = 0; i < Random.Range(-3f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaSkrga, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -35f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }

            ////////////////////////////////// Igla
            ///

            if (pos1.y < -230f && pos1.y > -280f)
            {
                for (int i = 0; i < Random.Range(-1f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaIgla, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -55f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if (pos1.y <= -280f)
                for (int i = 0; i < Random.Range(-3f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaIgla, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -55f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            ////////////////////////////////// crvena
            ///
            /// 
            if (pos1.y < -270f && pos1.y > -330f)
            {
                for (int i = 0; i < Random.Range(-2f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaCrvena, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -70f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            }
            else if (pos1.y <= -330f)
                for (int i = 0; i < Random.Range(-3f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaCrvena, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -70f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

                }
            //////////////////////////////////     zlatna


            if (pos1.y < -230f)
            {
                for (int i = 0; i < Random.Range(-5f, 0.9f); i++)
                {
                    ajkulaKlon = Instantiate(ribaZlatna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -120f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }
            }
            ///////////////////////////////////////// RAZNO

            if (pos1.y < -370f)
            {

                for (int i = 0; i < Random.Range(-4f, 1.5f); i++)
                {
                    ajkulaKlon = Instantiate(ribaZlatna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -120f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }

                for (int i = 0; i < Random.Range(-8f, 1.2f); i++)
                {
                    kutijaKlon = Instantiate(kutija, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -13f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    kutijaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }

            }

            if (pos1.y < -410f)
            {
                for (int i = 0; i < Random.Range(8f, 18f); i++)
                {
                    giftKlon = Instantiate(gift, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -11f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    giftKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }
                for (int i = 0; i < Random.Range(-3f, 1f); i++)
                {
                    kutijaKlon = Instantiate(kutija, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -13f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    kutijaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }
            }

            /////////////////////////////////////////  smece
            if (pos1.y < -10f)
                for(int i = 0; i < Random.Range(-5f, 1f); i++)
                {
                    smeceKlon = Instantiate(smece, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, 0f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    smeceKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }
            
            /////////////////////////////////    gift

            if(pos1.y<-20f)
                for (int i = 0; i < Random.Range(-7f, 1.6f); i++)
                {
                    giftKlon = Instantiate(gift, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -11f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    giftKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }
            if (pos1.y < -120f)
                for (int i = 0; i < Random.Range(-6f, 1.1f); i++)
                {
                    giftKlon = Instantiate(gift, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -11f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    giftKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }

            //////////////////////////////////  kutija

            if (pos1.y<-199f)
                for (int i = 0; i < Random.Range(-18f, 1f); i++)
                {
                    kutijaKlon = Instantiate(kutija, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 70f) / 7f, -13f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    kutijaKlon.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
                }

            ////////////////

            pos2.y-=5.12f;
        }
    }
    
}
