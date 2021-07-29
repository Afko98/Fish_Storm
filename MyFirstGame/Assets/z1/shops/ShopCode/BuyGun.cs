using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyGun : MonoBehaviour
{
    static bool sling = false, pistoli = false, pistolii = false,smg=false,pumpy1=false,pumpy2=false,ak=false,nade=false,minigun=false;
    static int slingp = 5, pistolip = 70, pistoliip = 140,smgp=800,pumpy1p=2200,pumpy2p=4400,akp=5500,nadep=9000,minigunp=13000;
    public Text v1, v2, v3,v4,v5,v6,v7,v8,v9;
    public GameObject coinupdate;

    private void Start()
    {
        if (sling)
            buysling();
        if (pistoli)
            buypistolI();
        if (pistolii)
            buypistolII();
        if (smg)
            buysmg();
        if (pumpy1)
            buypumpy1();
        if (pumpy2)
            buypumpy2();
        if (ak)
            buyak();
        if (nade)
            buynade();
        if (minigun)
            buyminigun();
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
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            nade = false;
            minigun = false;
            v1.GetComponent<Text>().text = "IN USE";
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + smgp;
            v5.GetComponent<Text>().text = "" + pumpy1p;
            v6.GetComponent<Text>().text = "" + pumpy2p;
            v7.GetComponent<Text>().text = "" + akp;
            v8.GetComponent<Text>().text = "" + nadep;
            v9.GetComponent<Text>().text = "" + minigunp;

            pucajRibu.brojMetaka = 3;
            uhvatiRibu.dmg = 0.7f;
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
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            nade = false;
            minigun = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "IN USE";
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + smgp;
            v5.GetComponent<Text>().text = "" + pumpy1p;
            v6.GetComponent<Text>().text = "" + pumpy2p;
            v7.GetComponent<Text>().text = "" + akp;
            v8.GetComponent<Text>().text = "" + nadep;
            v9.GetComponent<Text>().text = "" + minigunp;

            pucajRibu.brojMetaka = 3;
            uhvatiRibu.dmg = 0.7f*1.3f;
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
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            nade = false;
            minigun = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "IN USE";
            v4.GetComponent<Text>().text = "" + smgp;
            v5.GetComponent<Text>().text = "" + pumpy1p;
            v6.GetComponent<Text>().text = "" + pumpy2p;
            v7.GetComponent<Text>().text = "" + akp;
            v8.GetComponent<Text>().text = "" + nadep;
            v9.GetComponent<Text>().text = "" + minigunp;

            pucajRibu.brojMetaka = 6;
            uhvatiRibu.dmg = 0.7f*1.3f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buysmg()
    {
        if (currency.allCurrency >= smgp)
        {
            currency.allCurrency -= smgp;
            smgp = 0;
            sling = false;
            pistoli = false;
            pistolii = false;
            smg = true;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            nade = false;
            minigun = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "IN USE";
            v5.GetComponent<Text>().text = "" + pumpy1p;
            v6.GetComponent<Text>().text = "" + pumpy2p;
            v7.GetComponent<Text>().text = "" + akp;
            v8.GetComponent<Text>().text = "" + nadep;
            v9.GetComponent<Text>().text = "" + minigunp;

            pucajRibu.brojMetaka = 6;
            uhvatiRibu.dmg = 0.7f*1.6f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buypumpy1()
    {
        if (currency.allCurrency >= pumpy1p)
        {
            currency.allCurrency -= pumpy1p;
            pumpy1p = 0;
            sling = false;
            pistoli = false;
            pistolii = false;
            smg = false;
            pumpy1 = true;
            pumpy2 = false;
            ak = false;
            nade = false;
            minigun = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + smgp;
            v5.GetComponent<Text>().text = "IN USE";
            v6.GetComponent<Text>().text = "" + pumpy2p;
            v7.GetComponent<Text>().text = "" + akp;
            v8.GetComponent<Text>().text = "" + nadep;
            v9.GetComponent<Text>().text = "" + minigunp;

            pucajRibu.brojMetaka = 4;
            uhvatiRibu.dmg = 0.7f*2.1f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buypumpy2()
    {
        if (currency.allCurrency >= pumpy2p)
        {
            currency.allCurrency -= pumpy2p;
            pumpy2p = 0;
            sling = false;
            pistoli = false;
            pistolii = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = true;
            ak = false;
            nade = false;
            minigun = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + smgp;
            v5.GetComponent<Text>().text = "" + pumpy1p;
            v6.GetComponent<Text>().text = "IN USE";
            v7.GetComponent<Text>().text = "" + akp;
            v8.GetComponent<Text>().text = "" + nadep;
            v9.GetComponent<Text>().text = "" + minigunp;

            pucajRibu.brojMetaka = 4;
            uhvatiRibu.dmg = 0.7f*3.1f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyak()
    {
        if (currency.allCurrency >= akp)
        {
            currency.allCurrency -= akp;
            akp = 0;
            sling = false;
            pistoli = false;
            pistolii = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = true;
            nade = false;
            minigun = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + smgp;
            v5.GetComponent<Text>().text = "" + pumpy1p;
            v6.GetComponent<Text>().text = "" + pumpy2p;
            v7.GetComponent<Text>().text = "IN USE";
            v8.GetComponent<Text>().text = "" + nadep;
            v9.GetComponent<Text>().text = "" + minigunp;

            pucajRibu.brojMetaka = 8;
            uhvatiRibu.dmg = 0.7f*1.6f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buynade()
    {
        if (currency.allCurrency >= nadep)
        {
            currency.allCurrency -= nadep;
            nadep = 0;
            sling = false;
            pistoli = false;
            pistolii = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            nade = true;
            minigun = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + smgp;
            v5.GetComponent<Text>().text = "" + pumpy1p;
            v6.GetComponent<Text>().text = "" + pumpy2p;
            v7.GetComponent<Text>().text = "" + akp;
            v8.GetComponent<Text>().text = "IN USE";
            v9.GetComponent<Text>().text = "" + minigunp;

            pucajRibu.brojMetaka = 3;
            uhvatiRibu.dmg = 0.7f*4.7f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyminigun()
    {
        if (currency.allCurrency >= minigunp)
        {
            currency.allCurrency -= minigunp;
            minigunp = 0;
            sling = false;
            pistoli = false;
            pistolii = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            nade = false;
            minigun = true;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + smgp;
            v5.GetComponent<Text>().text = "" + pumpy1p;
            v6.GetComponent<Text>().text = "" + pumpy2p;
            v7.GetComponent<Text>().text = "" + akp;
            v8.GetComponent<Text>().text = "" + nadep;
            v9.GetComponent<Text>().text = "IN USE";

            uhvatiRibu.dmg = 0.7f*2.3f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

}
