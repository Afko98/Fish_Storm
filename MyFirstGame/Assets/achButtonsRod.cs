using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achButtonsRod : MonoBehaviour
{
    public Text v1, v2, v3, v4,v5,v6,v7;
    public static bool g1 = false, g2 = false, g3 = false, g4 = false, g5 = false,g6=false,g7=false;
    public GameObject coinUpdate;

    private void Start()
    {
        if (g1)
            v1.GetComponent<Text>().text = "DONE";
        if (g2)
            v2.GetComponent<Text>().text = "DONE";
        if (g3)
            v3.GetComponent<Text>().text = "DONE";
        if (g4)
            v4.GetComponent<Text>().text = "DONE";
        if (g5)
            v5.GetComponent<Text>().text = "DONE";
        if (g6)
            v6.GetComponent<Text>().text = "DONE";
        if (g7)
            v7.GetComponent<Text>().text = "DONE";

    }

    public void f1()
    {
        if (achivments.travel10000 && !g1)
        {
            currency.allCurrency += 5000;
            v1.GetComponent<Text>().text = "DONE";
            g1 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f2()
    {

        if (achivments.upTo50 && !g2)
        {
            currency.allCurrency += 500;
            v2.GetComponent<Text>().text = "DONE";
            g2 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f3()
    {
        if (achivments.upTo100 && !g3)
        {
            currency.allCurrency += 1000;
            v3.GetComponent<Text>().text = "DONE";
            g3 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

    public void f4()
    {
        if (achivments.upTo200 && !g4)
        {
            currency.allCurrency += 2000;
            v4.GetComponent<Text>().text = "DONE";
            g4 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f5()
    {
        if (achivments.upTo50wcf && !g5)
        {
            currency.allCurrency += 1000;
            v5.GetComponent<Text>().text = "DONE";
            g5 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f6()
    {
        if (achivments.upTo100wcf && !g6)
        {
            currency.allCurrency += 2000;
            v6.GetComponent<Text>().text = "DONE";
            g6 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void f7()
    {
        if (achivments.upTo200wcf && !g7)
        {
            currency.allCurrency += 4000;
            v7.GetComponent<Text>().text = "DONE";
            g7 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }




}
