using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnAkvariji : MonoBehaviour
{
    public static int brObicna=10, brStruja=10, brJelly=10, brDuga, brAjkula, brZlatna, brZlato, brBomb;
    public GameObject obicna, struja, jelly, duga, ajkula, zlatna, zlato, bomb;
    

    private void Start()
    {
        for(int i = 0; i < brObicna; i++)
        {
          var a = Instantiate(obicna, new Vector3(Random.Range(-23.5f, 23.5f) / 10f,Random.Range(-2.2f,0.5f)), transform.rotation * Quaternion.Euler(0f, Random.Range(0, 2) * 180f, 0f));
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
    }
}
