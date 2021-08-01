using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Data
{
    public int coins;
    public bool rod1 , rod2 , rod3, rod4 , rod5 , rod6;
    public int rod1p, rod2p, rod3p, rod4p, rod5p, rod6p;

    public bool hook1, hook2, hook3, hook4, hook5, hook6;
    public int hook1p, hook2p, hook3p, hook4p, hook5p, hook6p;

    public bool sling, pistoli, pistolii, smg, pumpy1, pumpy2, ak, nade, minigun;
    public int slingp, pistolip, pistoliip, smgp, pumpy1p, pumpy2p, akp, nadep, minigunp;

    public bool wormi, wormii, wormiii;
    public int wormip, wormiip, wormiiip;

    public int brojMaxZakacenihRibica;
    public float uze;
    public float brzinaKuke;

    public int brojMetaka;
    public float dmg;

    public Data()
    {
        coins = currency.allCurrency;
        rod1 = BuyRod.rod1;
        rod2 = BuyRod.rod2;
        rod3 = BuyRod.rod3;
        rod4 = BuyRod.rod4;
        rod5 = BuyRod.rod5;
        rod6 = BuyRod.rod6;

        rod1p = BuyRod.rod1p;
        rod2p = BuyRod.rod2p;
        rod3p = BuyRod.rod3p;
        rod4p = BuyRod.rod4p;
        rod5p = BuyRod.rod5p;
        rod6p = BuyRod.rod6p;

        hook1 = BuyHook.hook1;
        hook2 = BuyHook.hook2;
        hook3 = BuyHook.hook3;
        hook4 = BuyHook.hook4;
        hook5 = BuyHook.hook5;
        hook6 = BuyHook.hook6;

        hook1p = BuyHook.hook1p;
        hook2p = BuyHook.hook2p;
        hook3p = BuyHook.hook3p;
        hook4p = BuyHook.hook4p;
        hook5p = BuyHook.hook5p;
        hook6p = BuyHook.hook6p;

        sling = BuyGun.sling;
        pistoli = BuyGun.pistoli;
        pistolii = BuyGun.pistolii;
        smg = BuyGun.smg;
        pumpy1 = BuyGun.pumpy1;
        pumpy2 = BuyGun.pumpy2;
        ak = BuyGun.ak;
        nade = BuyGun.nade;
        minigun = BuyGun.minigun;

        slingp = BuyGun.slingp;
        pistolip = BuyGun.pistolip;
        pistoliip = BuyGun.pistoliip;
        smgp = BuyGun.smgp;
        pumpy1p = BuyGun.pumpy1p;
        pumpy2p = BuyGun.pumpy2p;
        akp = BuyGun.akp;
        nadep = BuyGun.nadep;
        minigunp = BuyGun.minigunp;

        wormi = buyBait.wormi;
        wormii = buyBait.wormii;
        wormiii = buyBait.wormiii;

        wormip = buyBait.wormip;
        wormiip = buyBait.wormiip;
        wormiiip = buyBait.wormiiip;

        brojMaxZakacenihRibica = CameraMove.brojMaxZakacenihRibica;
        uze = CameraMove.uze;

        brzinaKuke = FollowMouse.moveSpeed;

        brojMetaka = pucajRibu.brojMetaka;
        dmg = uhvatiRibu.dmg;


    }

    ////
    ///static bool rod1 = false, rod2 = false, rod3 = false,rod4=false,rod5=false,rod6=false;
    ///static int rod1p = 10, rod2p = 100, rod3p = 850, rod4p = 3000, rod5p = 8000, rod6p = 14000;
    ///static bool hook1 = false, hook2 = false, hook3 = false,hook4=false,hook5=false,hook6=false;
    ///static int hook1p = 5, hook2p = 100, hook3p = 850, hook4p = 1000, hook5p = 2000, hook6p = 4500;
    ///static bool sling = false, pistoli = false, pistolii = false,smg=false,pumpy1=false,pumpy2=false,ak=false,nade=false,minigun=false;
    ///static int slingp = 5, pistolip = 70, pistoliip = 140, smgp = 800, pumpy1p = 2200, pumpy2p = 4400, akp = 5500, nadep = 9000, minigunp = 13000;
    ///static bool wormi=false , wormii=false , wormiii=false ;
    ///static int wormip = 20, wormiip = 300, wormiiip = 1200;
    ///
}
