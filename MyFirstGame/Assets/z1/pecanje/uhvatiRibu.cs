using System.Collections.Generic;
using System.Collections;

using UnityEngine;
//lista nema ulogu, vazda je 1 el u njoj!

public class uhvatiRibu : MonoBehaviour
{
    public GameObject kuka, krv, krvKlon;
    public List<GameObject> ribaNiz = new List<GameObject>();
    public static float dmg = 1f;
    public static int bombExploded = 0;

  

    

    // Start is called before the first frame update
    public void Start()
    {
        ribaNiz = new List<GameObject>();
    
        kuka = GameObject.FindGameObjectWithTag("kuka");
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.name != "kuka1" || CameraMove.brojMaxZakacenihUIgri <= GameObject.FindGameObjectsWithTag("uhvacena").Length)
        {
            if (collider.name == "kuka1" && gameObject.tag == "bomb") { }
            else
                return;
        }

        if (gameObject.tag == "bomb")
        {
            GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayBombExsplosion();
            bombExploded++;
            if (bombExploded > 49)
                achivments.explode50 = true;
            uslovi.bombInOneGame++;
            if (uslovi.bombInOneGame == 3)
                achivments.explode3InGame = true;
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("uhvacena").Length / 2 - 0.1f; i++)
            {
                krvKlon = Instantiate(krv, kuka.transform.position, Quaternion.identity);
                krvKlon.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.35f, 0.35f));
                Destroy(GameObject.FindGameObjectsWithTag("uhvacena")[2 * i + 1]);
                CameraMove.brojMaxZakacenihUIgri -= 1;
                Destroy(gameObject);
            }
            return;
        }
        if (gameObject.tag == "bitePower")
        {
            CameraMove.brojMaxZakacenihUIgri += 3;
            Destroy(gameObject);
            return;
        }
        if (gameObject.tag == "boostPower")
        {
            Destroy(gameObject);
            return;
        }
        if (gameObject.tag == "bulletPower")
        {
            BrojMetaka.brojMetakaUIgri++;
            Destroy(gameObject);
            return;
        }
        if (gameObject.tag == "zlatna")
            uslovi.zlatnaInOneGame++;
        if (uslovi.zlatnaInOneGame == 5)
            achivments.catch5Goldfish = true;
        if (gameObject.tag == "chest")
            uslovi.chestInOneGame++;
        if (uslovi.chestInOneGame == 3)
            achivments.catch3GoldChests = true;

        if(Camera.main.transform.position.y<3)
        if (gameObject.GetComponent<BoxCollider2D>().enabled == true)
            gameObject.GetComponent<BoxCollider2D>().enabled = false;

        gameObject.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
        gameObject.transform.tag = "uhvacena";
        ribaNiz.Add(gameObject);

    }


    // Update is called once per frame

    public void Update()
    {


        if (Camera.main.transform.position.y > 6.9f  )
        {


            uslovi.daLiJeIspaljena = true;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ispaliRibice>().IspaliRibice();
        }
        if (!uslovi.daLiJeIspaljena && Camera.main.transform.position.y <= 2.7f)

            for (int i = 0; i < ribaNiz.Count; i++)
            {

                ribaNiz[i].transform.position = new Vector3(kuka.transform.position.x, kuka.transform.position.y, ribaNiz[i].transform.position.z);
                

            }
    }
    
   
}
