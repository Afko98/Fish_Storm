using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyHook : MonoBehaviour
{
    public static bool hook1 = false, hook2 = false, hook3 = false,hook4=false,hook5=false,hook6=false;
    public static int hook1p = 5, hook2p = 100, hook3p = 850, hook4p=1000, hook5p=2000,hook6p=4500;
    public Text v1, v2, v3,v4,v5,v6;
    public GameObject coinupdate;

    private void Start()
    {
        if (hook1)
            buyhook1();
        if (hook2)
            buyhook2();
        if (hook3)
            buyhook3();
        if (hook4)
            buyhook4();
        if (hook5)
            buyhook5();
        if (hook6)
            buyhook6();
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
            hook4 = false;
            hook5 = false;
            hook6 = false;
            v1.GetComponent<Text>().text = "IN USE";
            v2.GetComponent<Text>().text = "" + hook2p;
            v3.GetComponent<Text>().text = "" + hook3p;
            v4.GetComponent<Text>().text = "" + hook4p;
            v5.GetComponent<Text>().text = "" + hook5p;
            v6.GetComponent<Text>().text = "" + hook6p;
            FollowMouse.moveSpeed = 1.2f * 0.008f;

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
            hook4 = false;
            hook5 = false;
            hook6 = false;
            v1.GetComponent<Text>().text = "" + hook1p;
            v2.GetComponent<Text>().text = "IN USE";
            v3.GetComponent<Text>().text = "" + hook3p;
            v4.GetComponent<Text>().text = "" + hook4p;
            v5.GetComponent<Text>().text = "" + hook5p;
            v6.GetComponent<Text>().text = "" + hook6p;
            FollowMouse.moveSpeed = 1.5f * 0.008f;

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
            hook4 = false;
            hook5 = false;
            hook6 = false;
            v1.GetComponent<Text>().text = "" + hook1p;
            v2.GetComponent<Text>().text = "" + hook2p;
            v3.GetComponent<Text>().text = "IN USE";
            v4.GetComponent<Text>().text = "" + hook4p;
            v5.GetComponent<Text>().text = "" + hook5p;
            v6.GetComponent<Text>().text = "" + hook6p;
            FollowMouse.moveSpeed = 2f * 0.008f;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyhook4()
    {
        if (currency.allCurrency >= hook4p)
        {
            currency.allCurrency -= hook4p;
            hook4p = 0;
            hook2 = false;
            hook3 = false;
            hook4 = true;
            hook5 = false;
            hook6 = false;
            v1.GetComponent<Text>().text = "" + hook1p;
            v2.GetComponent<Text>().text = "" + hook2p;
            v3.GetComponent<Text>().text = "" + hook3p;
            v4.GetComponent<Text>().text = "IN USE";
            v5.GetComponent<Text>().text = "" + hook5p;
            v6.GetComponent<Text>().text = "" + hook6p;
            FollowMouse.moveSpeed = 3f * 0.008f;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyhook5()
    {
        if (currency.allCurrency >= hook5p)
        {
            currency.allCurrency -= hook5p;
            hook5p = 0;
            hook2 = false;
            hook3 = false;
            hook4 = false;
            hook5 = true;
            hook6 = false;
            v1.GetComponent<Text>().text = "" + hook1p;
            v2.GetComponent<Text>().text = "" + hook2p;
            v3.GetComponent<Text>().text = "" + hook3p;
            v4.GetComponent<Text>().text = "" + hook4p;
            v5.GetComponent<Text>().text = "IN USE";
            v6.GetComponent<Text>().text = "" + hook6p;
            FollowMouse.moveSpeed = 4f * 0.008f;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyhook6()
    {
        if (currency.allCurrency >= hook6p)
        {
            currency.allCurrency -= hook6p;
            hook6p = 0;
            hook2 = false;
            hook3 = false;
            hook4 = false;
            hook5 = false;
            hook6 = true;
            v1.GetComponent<Text>().text = "" + hook1p;
            v2.GetComponent<Text>().text = "" + hook2p;
            v3.GetComponent<Text>().text = "" + hook3p;
            v4.GetComponent<Text>().text = "" + hook4p;
            v5.GetComponent<Text>().text = "" + hook5p;
            v6.GetComponent<Text>().text = "IN USE";
            FollowMouse.moveSpeed = 5f * 0.008f;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

}
