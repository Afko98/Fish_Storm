using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ispaliRibice : MonoBehaviour
{
    public GameObject[] ribaNiz;
    bool uslov1 = false, uslov2 = false, uslov3 = false;
    private void Start()
    {
        uslov1 = false;
        uslov2 = false;
        uslov3 = false;

    }
    public void IspaliRibice()
    {
        
        ribaNiz = GameObject.FindGameObjectsWithTag("uhvacena");
        
        
            if (!uslov1 && ribaNiz.Length > 0)
                for (int i = 0; i < ribaNiz.Length; i += 3)
                {
                    if (!ribaNiz[i].GetComponent<Collider2D>().enabled)
                        ribaNiz[i].GetComponent<Collider2D>().enabled = !ribaNiz[i].GetComponent<Collider2D>().enabled;

                    ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(0f, 125f) / 25f + 5.2f, 0f);
                    ribaNiz[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz[i].GetComponent<Rigidbody2D>().drag = 0.18f;
                    ribaNiz[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                    ribaNiz[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                    uslov1 = true;

                }
            if (Camera.main.transform.position.y > 6f && !uslov2 && ribaNiz.Length > 1)
                for (int i = 1; i < ribaNiz.Length; i += 3)
                {
                    if (!ribaNiz[i].GetComponent<Collider2D>().enabled)
                        ribaNiz[i].GetComponent<Collider2D>().enabled = !ribaNiz[i].GetComponent<Collider2D>().enabled;

                    ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(0f, 125f) / 25f + 5.9f, 0f);
                    ribaNiz[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz[i].GetComponent<Rigidbody2D>().drag = 0.18f;
                    ribaNiz[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                    ribaNiz[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                    uslov2 = true;

                }
            if (Camera.main.transform.position.y > 7.5f && !uslov3 && ribaNiz.Length > 2)
                for (int i = 2; i < ribaNiz.Length; i += 3)
                {
                    if (!ribaNiz[i].GetComponent<Collider2D>().enabled)
                        ribaNiz[i].GetComponent<Collider2D>().enabled = !ribaNiz[i].GetComponent<Collider2D>().enabled;

                    ribaNiz[i].GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(0f, 900f) / 100f - 4.5f, Random.Range(0f, 125f) / 25f + 6.6f, 0f);
                    ribaNiz[i].GetComponent<Rigidbody2D>().gravityScale = 0.3f;
                    ribaNiz[i].GetComponent<Rigidbody2D>().drag = 0.18f;
                    ribaNiz[i].GetComponent<Rigidbody2D>().rotation = Random.Range(-180f, 180f);
                    ribaNiz[i].GetComponent<BoxCollider2D>().size = new Vector2(uhvatiRibu.dmg, uhvatiRibu.dmg);
                    uslov3 = true;

                }
            

    }

    private void Update()
    {
        for (int i = 0; i < ribaNiz.Length; i++)
        {
            if (ribaNiz[i].transform.position.x > 2.6f)
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

   public IEnumerator waitSomeTime()
    {
        yield return new WaitForSeconds(2f);
    }

}
