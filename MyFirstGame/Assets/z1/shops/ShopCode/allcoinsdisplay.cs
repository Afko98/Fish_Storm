using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class allcoinsdisplay : MonoBehaviour
{
    public GameObject allCur,tekst;

    public void Start()
    {
        Koliko();
    }
    public void Koliko()
    {
        tekst.GetComponent<Text>().text = ""+ currency.allCurrency;
    }

}
