using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyHook : MonoBehaviour
{
    static bool hook1 = false, hook2 = false, hook3 = false;
    static int hook1p = 5, hook2p = 100, hook3p = 850;
    public Text v1, v2, v3;
    public GameObject coinupdate;

    private void Start()
    {
        if (hook1)
            buyhook1();
        if (hook2)
            buyhook2();
        if (hook3)
            buyhook3();
    }

    //v1.GetComponent<Text>().text = "IN USE";
    public void buyhook1()
    {
        if (currency.allCurrency >= hook1p)
        {
            currency.allCurrency -= hook1p;
            hook1p = 0;
            hook1 = true;
            hook2 = false;
            hook3 = false;
            v1.GetComponent<Text>().text = "IN USE";
            v2.GetComponent<Text>().text = "" + hook2p;
            v3.GetComponent<Text>().text = "" + hook3p;
            
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyhook2()
    {
        if (currency.allCurrency >= hook2p)
        {
            currency.allCurrency -= hook2p;
            hook2p = 0;
            hook1 = false;
            hook2 = true;
            hook3 = false;
            v1.GetComponent<Text>().text = "" + hook1;
            v2.GetComponent<Text>().text = "IN USE";
            v3.GetComponent<Text>().text = "" + hook3;
           
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyhook3()
    {
        if (currency.allCurrency >= hook3p)
        {
            currency.allCurrency -= hook3p;
            hook3p = 0;
            hook1 = false;
            hook2 = false;
            hook3 = true;
            v1.GetComponent<Text>().text = "" + hook1p;
            v2.GetComponent<Text>().text = "" + hook2p;
            v3.GetComponent<Text>().text = "IN USE";
            
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

}
