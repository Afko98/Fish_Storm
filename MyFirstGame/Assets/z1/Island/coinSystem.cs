using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class coinSystem : MonoBehaviour
{
    
    public GameObject coin,obj;
    public static int coinsOnScreen=0;
    TimeSpan petMin = new TimeSpan(0, 5, 0);
    TimeSpan maxVrijeme = new TimeSpan(3, 0, 0);
    public static DateTime startTime=DateTime.UtcNow;

    

    private void Update()
    {
        TimeSpan currentTime = DateTime.UtcNow - startTime;
        if (currentTime > maxVrijeme)
            startTime = DateTime.UtcNow - new TimeSpan(2, 55, 1);

        if (currentTime >= petMin)
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
            Destroy(gameObject);
        }
    }


}
