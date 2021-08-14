using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutPopup : MonoBehaviour
{
    public GameObject tut;
    static public bool tutFirstTime = true;

    private void Start()
    {
        if (tutFirstTime)
        {
            tutFirstTime = false;
        }
        else if (!tutFirstTime)
            tut.SetActive(false);
    }
    public void ugasi()
    {
        tut.SetActive(false);
    }
}
