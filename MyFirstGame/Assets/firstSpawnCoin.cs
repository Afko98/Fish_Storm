using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstSpawnCoin : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < coinSystem.coinsOnScreen; i++)
        {
            Instantiate(coin, new Vector2(UnityEngine.Random.Range(-2.3f, 2.5f), -2.4f), Quaternion.identity);
        }
    }   
}
