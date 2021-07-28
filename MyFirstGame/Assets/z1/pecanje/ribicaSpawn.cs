
using UnityEngine;

public class ribicaSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject ribaObicna, ribaStruja, ribaJelly;

    public Vector3 pos2 = Camera.main.transform.position;
    public GameObject obicnaKlon,strujaKlon,jellyKlon;
    public int brojacObicna = 0,brojacStruja=0;


    private void Start()
    {
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
                for (int i = 0; i < Random.Range(10f, 30f); i++)
                {
                    obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f)/6f,-1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    obicnaKlon.name = "ribaObicna" + brojacObicna;
                    brojacObicna++;
                }
                else if(pos1.y>-35)
                    for (int i = 0; i < Random.Range(6f, 14f); i++)
                    {
                        obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f)/10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                        obicnaKlon.name = "ribaObicna" + brojacObicna;
                        brojacObicna++;
                    }
                else 
                for (int i = 0; i < Random.Range(0f, 4f); i++)
                {
                    obicnaKlon = Instantiate(ribaObicna, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -1f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    obicnaKlon.name = "ribaObicna" + brojacObicna;
                    brojacObicna++;
                }

                ///////////////////////////////////////////////////////////////
            if (pos1.y < -22f && pos1.y>-55f)
            {
                for (int i = 0; i < Random.Range(4f, 13f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f,-3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    brojacStruja++;
                }
            }
            else if ((pos1.y < -55 && pos1.y>-90)|| (pos1.y < -12 && pos1.y > -22))
            {
                for (int i = 0; i < Random.Range(2f, 6f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y -5.12f - Random.Range(0f, 60f) / 6f, -3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    brojacStruja++;
                }
            }
            else if (pos1.y < -90f)
                for (int i = 0; i < Random.Range(0f, 4f); i++)
                {
                    strujaKlon = Instantiate(ribaStruja, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -3f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaStruja" + brojacStruja;
                    brojacStruja++;
                }
            ///////////////////////////////

            if (pos1.y < -49f && pos1.y > -100f)
            {
                for (int i = 0; i < Random.Range(3f, 8f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f,-8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaJelly" + brojacStruja;
                    
                }
            }
            else if(pos1.y < -100f && pos1.y>-150f)
                for (int i = 0; i < Random.Range(2f, 5f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaJelly" + brojacStruja;

                }
            else if(pos1.y<-150f)
                for (int i = 0; i < Random.Range(0f, 3f); i++)
                {
                    strujaKlon = Instantiate(ribaJelly, new Vector3(Random.Range(-24f, 24f) / 10f, pos2.y - 5.12f - Random.Range(0f, 60f) / 6f, -8f), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f)) as GameObject;
                    strujaKlon.name = "ribaJelly" + brojacStruja;

                }
            pos2.y-=5.12f;
        }
    }
}
