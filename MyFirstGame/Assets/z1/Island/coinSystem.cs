using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class coinSystem : MonoBehaviour
{
    
    public GameObject coin,obj,coinUpdate;
    public static int coinsOnScreen=0;
    TimeSpan petMin = new TimeSpan(0, 20, 0);
    TimeSpan maxVrijeme = new TimeSpan(12, 0, 0);
    public static DateTime startTime=DateTime.UtcNow;

    

    private void Update()
    {
        
        if (coinsOnScreen >= maxVrijeme.TotalSeconds / petMin.TotalSeconds * spawnAkvariji.brRibicaUAkvarijumu)
            startTime = DateTime.UtcNow;

        TimeSpan currentTime = DateTime.UtcNow - startTime;
        if (currentTime > maxVrijeme)
            startTime = DateTime.UtcNow - new TimeSpan(11, 55, 1);

        if (currentTime >= petMin && coinsOnScreen<=maxVrijeme.TotalSeconds /petMin.TotalSeconds *spawnAkvariji.brRibicaUAkvarijumu)
        {
            startTime += petMin;
            for (int i = 0; i < spawnAkvariji.brRibicaUAkvarijumu; i++)
            {
                coinsOnScreen++;
                Instantiate(coin, new Vector2(UnityEngine.Random.Range(-2.3f, 2.5f), -2.4f), Quaternion.identity);
            }
        }

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (transform.position.x < (cursorPos.x + 0.1f) && transform.position.x > (cursorPos.x - 0.1f) && transform.position.y < (cursorPos.y + 0.1f) && transform.position.y > (cursorPos.y - 0.1f))
        {
            Instantiate(obj, transform.position, Quaternion.identity);
            currency.allCurrency++;
            coinsOnScreen--;
            coinUpdate.GetComponent<coinCityUpdate>().UpdateCoinsCity();
            Destroy(gameObject);
        }
    }


}
