
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

        float i = Random.Range(0.2f, 3.2f);
        if(i>=3)
            blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 100f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
           if(i>=2)
        blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 140f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
        if(i>=1)
        blagoKlon = Instantiate(blago, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 180f - Random.Range(0f, 40f), -200f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
        
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
                for (int i = 0; i < Random.Range(15f, 37f); i++)
                {
                    obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f)/6f,-1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    obicnaKlon.name = "ribaObicna" + brojacObicna;
                    brojacObicna++;
                }
                else if(pos1.y>-35)
                    for (int i = 0; i < Random.Range(8f, 17f); i++)
                    {
                        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f)/10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                        obicnaKlon.name = "ribaObicna" + brojacObicna;
                        brojacObicna++;
                    }
                else 
                for (int i = 0; i < Random.Range(1f, 7f); i++)
                {
                    obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    obicnaKlon.name = "ribaObicna" + brojacObicna;
                    brojacObicna++;
                }

                ///////////////////////////////////////////////////////////////
            if (pos1.y < -22f && pos1.y>-55f)
            {
                for (int i = 0; i < Random.Range(5f, 12f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f,-3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    brojacStruja++;
                }
            }
            else if ((pos1.y <= -55 && pos1.y>-80)|| (pos1.y < -12 && pos1.y >= -22))
            {
                for (int i = 0; i < Random.Range(3f, 7f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y -5.12f - Random.Range(0f, 60f) / 6f, -3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    brojacStruja++;
                }
            }
            else if (pos1.y < -80f)
                for (int i = 0; i < Random.Range(0f, 3f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    brojacStruja++;
                }
            ///////////////////////////////

            if (pos1.y < -49f && pos1.y > -90f)
            {
                for (int i = 0; i < Random.Range(2f, 8f); i++)
                {
                    jellyKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f,-8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    jellyKlon.name = "ribaJelly" + brojacStruja;
                    
                }
            }
            else if(pos1.y <= -90f && pos1.y>-130f)
                for (int i = 0; i < Random.Range(1f, 5f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaJelly" + brojacStruja;

                }
            else if(pos1.y<-130f || (pos1.y<-37 && pos1.y>=-49))
                for (int i = 0; i < Random.Range(0f, 3f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaJelly" + brojacStruja;

                }
            /////////////////////////////////////////

            if (pos1.y < -90f && pos1.y > -130f)
            {
                for (int i = 0; i < Random.Range(4f, 9f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -15f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaRavna" + brojacStruja;

                }
            }
            else if (pos1.y <= -130f && pos1.y > -160f)
                for (int i = 0; i < Random.Range(1f, 4f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -15f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaRavna" + brojacStruja;

                }
            else if (pos1.y < -180f || (pos1.y < -70 && pos1.y >= -90))
                for (int i = 0; i < Random.Range(0f, 3f); i++)
                {
                    ravnaKlon = Instantiate(ribaRavna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -15f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaRavna" + brojacStruja;

                }

            //////////////////////////////////
            if (pos1.y < -140f && pos1.y > -210f)
            {
                for (int i = 0; i < Random.Range(1f, 6f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -28f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.name = "ribaRavna" + brojacStruja;

                }
            }
            else if (pos1.y <= -210f && pos1.y > -250f)
                for (int i = 0; i < Random.Range(0f, 4f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -28f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.name = "ribaRavna" + brojacStruja;

                }
            else if (pos1.y <= -250f || (pos1.y < -110f && pos1.y >= -140f))
                for (int i = 0; i < Random.Range(0f, 2f); i++)
                {
                    ajkulaKlon = Instantiate(ribaAjkula, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -28f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    ajkulaKlon.name = "ribaRavna" + brojacStruja;

                }
            //////////////////////////////////
            

            if (pos1.y < -240f)
            {
                for (int i = 0; i < Random.Range(-1f, 1.4f); i++)
                {
                    ajkulaKlon = Instantiate(ribaZlatna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -100f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                }
            }

            //////////////////////////////////

            pos2.y-=5.12f;
        }
    }
}
