using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achButtonsHook : MonoBehaviour
{
    public Text v1, v2, v3, v4;
    public static bool e1 = false, e2 = false, e3 = false, e4 = false;
    public GameObject coinUpdate;

    private void Start()
    {
        if (e1)
            v1.GetComponent<Text>().text = "DONE";
        if (e2)
            v2.GetComponent<Text>().text = "DONE";
        if (e3)
            v3.GetComponent<Text>().text = "DONE";
        if (e4)
            v4.GetComponent<Text>().text = "DONE";
      
      
    }

    public void f1()
    {
        if (achivments.explode3InGame && !e1)
        {
            currency.allCurrency += 500;
            v1.GetComponent<Text>().text = "DONE";
            e1 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f2()
    {

        if (achivments.explode50 && !e2)
        {
            currency.allCurrency += 5000;
            v2.GetComponent<Text>().text = "DONE";
            e2 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f3()
    {
        if (achivments.catch5Goldfish && !e3)
        {
            currency.allCurrency += 1500;
            v3.GetComponent<Text>().text = "DONE";
            e3 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

    public void f4()
    {
        if (achivments.catch3GoldChests && !e4)
        {
            currency.allCurrency += 1500;
            v4.GetComponent<Text>().text = "DONE";
            e4 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
 
   


}
