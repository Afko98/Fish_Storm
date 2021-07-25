using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyGun : MonoBehaviour
{
    static bool sling = false, pistoli = false, pistolii = false;
    static int slingp = 5, pistolip = 100, pistoliip = 850;
    public Text v1, v2, v3;
    public GameObject coinupdate;

    private void Start()
    {
        if (sling)
            buysling();
        if (pistoli)
            buypistolI();
        if (pistolii)
            buypistolII();
    }

    //v1.GetComponent<Text>().text = "IN USE";
    public void buysling()
    {
        if (currency.allCurrency >= slingp)
        {
            currency.allCurrency -= slingp;
            slingp = 0;
            sling = true;
            pistoli = false;
            pistolii = false;
            v1.GetComponent<Text>().text = "IN USE";
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buypistolI()
    {
        if (currency.allCurrency >= pistolip)
        {
            currency.allCurrency -= pistolip;
            pistolip = 0;
            sling = false;
            pistoli = true;
            pistolii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "IN USE";
            v3.GetComponent<Text>().text = "" + pistoliip;
           
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buypistolII()
    {
        if (currency.allCurrency >= pistoliip)
        {
            currency.allCurrency -= pistoliip;
            pistoliip = 0;
            sling = false;
            pistoli = false;
            pistolii = true;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "IN USE";
            
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

}
