using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyGun : MonoBehaviour
{
    public static bool sling = false, pistoli = false, pistolii = false,uzi=false,sniper=false,nadeLauncher=false,rpg=false,rpgii=false,smg=false,pumpy1=false,pumpy2=false,ak=false,nade=false,minigun=false;
    public static int slingp = 10, pistolip = 100, pistoliip = 200,uzip=800,smgp=2000,pumpy1p=3300,pumpy2p=6600,akp=8500,sniperp=11500,minigunp=17000,nadep=25000,nadeLauncherp=40000,rpgp=70000,rpgiip=120000,ammop=40;
    public Text v1, v2, v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15;
    public GameObject coinupdate;
    public Text text; //ADDS 1 MORE SHOOT
    //YOU NOW HAVE: x SHOOTS

    private void Start()
    {
        v1.GetComponent<Text>().text = ""+slingp;
        v2.GetComponent<Text>().text = "" + pistolip;
        v3.GetComponent<Text>().text = "" + pistoliip;
        v4.GetComponent<Text>().text = "" + uzip;
        v5.GetComponent<Text>().text = "" + smgp;
        v6.GetComponent<Text>().text = "" + pumpy1p;
        v7.GetComponent<Text>().text = "" + pumpy2p;
        v8.GetComponent<Text>().text = "" + akp;
        v9.GetComponent<Text>().text = "" + sniperp;
        v11.GetComponent<Text>().text = "" + minigunp;
        v12.GetComponent<Text>().text = "" + nadep;
        v13.GetComponent<Text>().text = "" + nadeLauncherp;
        v14.GetComponent<Text>().text = "" + rpgp;
        v15.GetComponent<Text>().text = "" + rpgiip;

        v10.GetComponent<Text>().text = "" + ammop;
        text.GetComponent<Text>().text = "ADDS 1 MORE SHOOT \nYOU NOW HAVE: " + pucajRibu.brojMetaka + " SHOTS";

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
        if (sniper)
            buySniper();
        if (uzi)
            buyUzi();
        if (rpg)
            buyRPG();
        if (rpgii)
            buyRPGII();
        if (nadeLauncher)
            buyNadeLauncher();
    }

    public void buyAmmo()
    {
        if (currency.allCurrency >= ammop)
        {
            currency.allCurrency -= ammop;
            if (ammop < 1000)
                ammop *= 3;
            else
                ammop *= 2;
            pucajRibu.brojMetaka++;
            v10.GetComponent<Text>().text = "" + ammop;
            text.GetComponent<Text>().text = "ADDS 1 MORE SHOOT \nYOU NOW HAVE: " + pucajRibu.brojMetaka + " SHOOTS";
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyUzi()
    {
        if (currency.allCurrency >= uzip)
        {
            currency.allCurrency -= uzip;
            uzip = 0;

            sling = false;
            pistoli = false;
            pistolii = false;
            uzi = true;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;

            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "IN USE";
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 100;
            uhvatiRibu.dmg = 0.8f * 1.5f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buySniper()
    {
        if (currency.allCurrency >= sniperp)
        {
            currency.allCurrency -= sniperp;
            sniperp = 0;

            sling = false;
            pistoli = false;
            pistolii = false;
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = true;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;

            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "IN USE";
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 75;
            uhvatiRibu.dmg = 0.8f * 2.4f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyNadeLauncher()
    {
        if (currency.allCurrency >= nadeLauncherp)
        {
            currency.allCurrency -= nadeLauncherp;
            nadeLauncherp = 0;

            sling = false;
            pistoli = false;
            pistolii = false;
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = true;
            minigun = false;
            rpg = false;
            rpgii = false;

            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = ""+uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "IN USE";
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 60;
            uhvatiRibu.dmg = 0.8f * 3.2f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyRPG()
    {
        if (currency.allCurrency >= rpgp)
        {
            currency.allCurrency -= rpgp;
            rpgp = 0;

            sling = false;
            pistoli = false;
            pistolii = false;
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = true;
            rpgii = false;

            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = ""+nadeLauncherp;
            v14.GetComponent<Text>().text = "IN USE";
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 50;
            uhvatiRibu.dmg = 0.8f * 3.5f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyRPGII()
    {
        if (currency.allCurrency >= rpgiip)
        {
            currency.allCurrency -= rpgiip;
            rpgiip = 0;

            sling = false;
            pistoli = false;
            pistolii = false;
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = true;

            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = ""+rpgp;
            v15.GetComponent<Text>().text = "IN USE";
            ShakeCam.shakePower = 50;
            uhvatiRibu.dmg = 0.8f * 3.8f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buysling()
    {
        if (currency.allCurrency >= slingp)
        {
            currency.allCurrency -= slingp;
            slingp = 0;
            sling = true;
            pistoli = false;
            pistolii = false;
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "IN USE";
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 120;
            uhvatiRibu.dmg = 0.8f*1.1f;
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
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "IN USE";
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 110;
            uhvatiRibu.dmg = 0.8f*1.2f;
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
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "IN USE";
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 105;
            uhvatiRibu.dmg = 0.8f*1.4f;
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
            uzi = false;
            smg = true;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "IN USE";
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 110;
            uhvatiRibu.dmg = 0.8f*1.6f;
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
            uzi = false;
            smg = false;
            pumpy1 = true;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "IN USE";
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 90;
            uhvatiRibu.dmg = 0.8f*1.75f;
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
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = true;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "IN USE";
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 80;
            uhvatiRibu.dmg = 0.8f*2f;
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
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = true;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "IN USE";
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 90;
            uhvatiRibu.dmg = 0.8f*2.2f;
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
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = true;
            nadeLauncher = false;
            minigun = false;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "" + minigunp;
            v12.GetComponent<Text>().text = "IN USE";
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 70;
            uhvatiRibu.dmg = 0.8f*2.9f;
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
            uzi = false;
            smg = false;
            pumpy1 = false;
            pumpy2 = false;
            ak = false;
            sniper = false;
            nade = false;
            nadeLauncher = false;
            minigun = true;
            rpg = false;
            rpgii = false;
            v1.GetComponent<Text>().text = "" + slingp;
            v2.GetComponent<Text>().text = "" + pistolip;
            v3.GetComponent<Text>().text = "" + pistoliip;
            v4.GetComponent<Text>().text = "" + uzip;
            v5.GetComponent<Text>().text = "" + smgp;
            v6.GetComponent<Text>().text = "" + pumpy1p;
            v7.GetComponent<Text>().text = "" + pumpy2p;
            v8.GetComponent<Text>().text = "" + akp;
            v9.GetComponent<Text>().text = "" + sniperp;
            v11.GetComponent<Text>().text = "IN USE";
            v12.GetComponent<Text>().text = "" + nadep;
            v13.GetComponent<Text>().text = "" + nadeLauncherp;
            v14.GetComponent<Text>().text = "" + rpgp;
            v15.GetComponent<Text>().text = "" + rpgiip;

            ShakeCam.shakePower = 80;
            uhvatiRibu.dmg = 0.8f*2.6f;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

}
