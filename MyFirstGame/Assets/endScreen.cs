using System;
using UnityEngine;
using UnityEngine.UI;

public class endScreen : MonoBehaviour
{
    // Start is called before the first frame update
    DateTime startTime;
    public GameObject menu;
    bool uslov;
    TimeSpan maxVrijeme = new TimeSpan(0, 0, 2);

    void Start()
    {
        menu.SetActive(false);
        uslov = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if (pucajRibu.brM < 1 && !uslov && Camera.main.transform.position.y>2.2f)
        {
           startTime = DateTime.UtcNow;
            uslov = true;
        }
        if (uslov && DateTime.UtcNow-startTime>maxVrijeme)
        {
            menu.SetActive(true);
        }
    }
}
