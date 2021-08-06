using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class coinSystem : MonoBehaviour
{
    public GameObject coin;
    public static int coinValue = 1;
    TimeSpan desetMin = new TimeSpan(0, 0, 2);
    public static DateTime startTime=DateTime.UtcNow;
    
    

    private void Update()
    {
        TimeSpan currentTime = DateTime.UtcNow - startTime;

        if (currentTime >= desetMin)
        {
            startTime += desetMin;
            Instantiate(coin, new Vector2(UnityEngine.Random.Range(-2.3f, 2.5f), -2.4f),Quaternion.identity);
        }

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (transform.position.x < (cursorPos.x + 0.1f) && transform.position.x > (cursorPos.x - 0.1f) && transform.position.y < (cursorPos.y + 0.1f) && transform.position.y > (cursorPos.y - 0.1f))
        {
            Destroy(gameObject);
        }
    }


}
