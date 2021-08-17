using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnAkvariji : MonoBehaviour
{
    public static int brObicna = 0, brStruja = 0, brJelly = 0, brDuga = 0, brAjkula = 0, brZlatna = 0, brDiver = 0, brZlato=0, brBomb=0,brCrvena=0,brPodmornica=0;
    public GameObject obicna, struja, jelly, duga, ajkula, zlatna, zlato, bomb,crvena,diver,podmornica;
    public static int brRibicaUAkvarijumu;

    private void Awake()
    {
        brRibicaUAkvarijumu = brObicna + brStruja + brJelly + brDuga + brAjkula + brZlatna + brZlato + brBomb+brCrvena;
        if (brRibicaUAkvarijumu > 9)
            achivments.have10InAq = true;
        if (brRibicaUAkvarijumu > 19)
            achivments.have20InAq = true;
        if (brRibicaUAkvarijumu > 39)
            achivments.have40InAq = true;
    }
    private void Start()
    {
        
        for (int i = 0; i < brObicna; i++)
        {
          var a = Instantiate(obicna, new Vector3(Random.Range(-23.5f, 23.5f) / 10f,Random.Range(-2.2f,0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
        for (int i = 0; i < brPodmornica; i++)
        {
            var a = Instantiate(podmornica, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
        for (int i = 0; i < brDiver; i++)
        {
            var a = Instantiate(diver, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
        for (int i = 0; i < brJelly; i++)
        {
            var a = Instantiate(jelly, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);

        }
        for (int i = 0; i < brStruja; i++)
        {
            var a=Instantiate(struja, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
        for (int i = 0; i < brDuga; i++)
        {
            var a = Instantiate(duga, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
        for (int i = 0; i < brAjkula; i++)
        {
            var a = Instantiate(ajkula, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
        for (int i = 0; i < brZlatna; i++)
        {
            var a = Instantiate(zlatna, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
        for (int i = 0; i < brZlato; i++)
        {
            var a = Instantiate(zlato, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
        for (int i = 0; i < brBomb; i++)
        {
            var a = Instantiate(bomb, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 3);
        }
        for (int i = 0; i < brCrvena; i++)
        {
            var a = Instantiate(crvena, new Vector3(Random.Range(-23.5f, 23.5f) / 10f, Random.Range(-2.2f, 0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
            a.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(0, 8);
        }
    }
}
