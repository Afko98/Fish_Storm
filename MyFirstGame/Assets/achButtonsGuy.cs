using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achButtonsGuy : MonoBehaviour
{
    public Text v1, v2, v3, v4, v5, v6, v7;
    public static bool d1 = false, d2 = false, d3 = false, d4 = false, d5 = false, d6 = false, d7 = false;
    public GameObject coinUpdate;

    private void Start()
    {
        if (d1)
            v1.GetComponent<Text>().text = "DONE";
        if (d2)
            v2.GetComponent<Text>().text = "DONE";
        if (d3)
            v3.GetComponent<Text>().text = "DONE";
        if (d4)
            v4.GetComponent<Text>().text = "DONE";
        if (d5)
            v5.GetComponent<Text>().text = "DONE";
        if (d6)
            v6.GetComponent<Text>().text = "DONE";
        if (d7)
            v7.GetComponent<Text>().text = "DONE";
      
    }

    public void f1()
    {
        if (achivments.watch5 && !d1)
        {
            currency.allCurrency += 500;
            v1.GetComponent<Text>().text = "DONE";
            d1 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f2()
    {

        if (achivments.watch10 && !d2)
        {
            currency.allCurrency += 1000;
            v2.GetComponent<Text>().text = "DONE";
            d2 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f3()
    {
        if (achivments.watch20 && !d3)
        {
            giftScript.brGift += 200;
            v3.GetComponent<Text>().text = "DONE";
            d3 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

    public void f4()
    {
        if (achivments.buyIsland && !d4)
        {
            currency.allCurrency += 1500;
            v4.GetComponent<Text>().text = "DONE";
            d4 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f5()
    {
        if (achivments.have10InAq && !d5)
        {
            currency.allCurrency += 1000;
            v5.GetComponent<Text>().text = "DONE";
            d5 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f6()
    {
        if (achivments.have20InAq && !d6)
        {
            currency.allCurrency += 2000;
            v6.GetComponent<Text>().text = "DONE";
            d6 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f7()
    {
        if (achivments.have40InAq && !d7)
        {
            currency.allCurrency += 5000;
            v7.GetComponent<Text>().text = "DONE";
            d7 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
   


}
