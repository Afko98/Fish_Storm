using System.Collections.Generic;
using UnityEngine;
//lista nema ulogu, vazda je 1 el u njoj!

public class uhvatiRibu : MonoBehaviour
{
    public GameObject kuka;
    public List<GameObject> ribaNiz = new List<GameObject>();
    public static float dmg = 0.6f;
   
    public bool daLiJeIspaljena = false;

    // Start is called before the first frame update
    public void Start()
    {
        
        kuka = GameObject.FindGameObjectWithTag("kuka");
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name != "kuka1" || CameraMove.brojMaxZakacenihRibica <= GameObject.FindGameObjectsWithTag("uhvacena").Length)
            return;
        gameObject.GetComponent<Collider2D>().enabled = !gameObject.GetComponent<Collider2D>().enabled;
        gameObject.GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
        ribaNiz.Add(gameObject);
        
    }
 
    
    // Update is called once per frame
    
    public void Update()
    {

     

        if (Camera.main.transform.position.y >4.9f )
        {
            
            IspaliRibice();
        }
        if(!daLiJeIspaljena && Camera.main.transform.position.y<=2.7f)

        for(int i = 0; i < ribaNiz.Count; i++)
        {
                
                

            ribaNiz[i].transform.position = new Vector3(kuka.transform.position.x,kuka.transform.position.y,ribaNiz[i].transform.position.z);
            ribaNiz[i].transform.tag = "uhvacena";

        }
    }
    public void IspaliRibice()
    {
        
        for(int i = 0; i < ribaNiz.Count; i++)
        {
            if (!ribaNiz[i].GetComponent<Collider2D>().enabled)
                ribaNiz[i].GetComponent<Collider2D>().enabled = !ribaNiz[i].GetComponent<Collider2D>().enabled;
            if (!daLiJeIspaljena)
            {
                daLiJeIspaljena = true;
                ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(0f, 125f) / 25f+7.2f , 0f);
                ribaNiz[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                ribaNiz[i].GetComponent<Rigidbody2D>().drag = 0.3f;
                ribaNiz[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                
                ribaNiz[i].GetComponent<BoxCollider2D>().size = new Vector2(dmg,dmg);

            }
            

            if(ribaNiz[i].transform.position.x > 2.6f)
            {
                ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(-ribaNiz[i].GetComponent<Rigidbody2D>().velocity.x, ribaNiz[i].GetComponent<Rigidbody2D>().velocity.y, 0f);
                ribaNiz[i].transform.position = new Vector3(ribaNiz[i].transform.position.x - 0.1f, ribaNiz[i].transform.position.y, ribaNiz[i].transform.position.z);
            }
            if (ribaNiz[i].transform.position.x < -2.6f)
            {
                ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(-ribaNiz[i].GetComponent<Rigidbody2D>().velocity.x, ribaNiz[i].GetComponent<Rigidbody2D>().velocity.y, 0f);
                ribaNiz[i].transform.position = new Vector3(ribaNiz[i].transform.position.x + 0.1f, ribaNiz[i].transform.position.y, ribaNiz[i].transform.position.z);
            }

        }
    }
}
