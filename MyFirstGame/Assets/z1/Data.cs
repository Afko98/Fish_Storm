using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[System.Serializable]
public class Data
{
    public int coins;
    public bool rod1 , rod2 , rod3, rod4 , rod5 , rod6,rod7,rod8;
    public int rod1p, rod2p, rod3p, rod4p, rod5p, rod6p,rod7p,rod8p;

    public bool hook1, hook2, hook3, hook4, hook5, hook6;
    public int hook1p, hook2p, hook3p, hook4p, hook5p, hook6p;

    public bool sling, pistoli, pistolii, smg, pumpy1, pumpy2, ak, nade, minigun,uzi,sniper,nadeLauncher,rpg,rpgii;
    public int slingp, pistolip, pistoliip, smgp, pumpy1p, pumpy2p, akp, nadep, minigunp,uzip,sniperp,nadeLauncherp,rpgp,rpgiip,ammop;

    public int baitp;

    public int fish1p, fish2p, fish3p, fish4p, fish5p, fish6p, fish7p, fish8p, fish9p;

    public int fuelp;

    public float boostTime;

    public bool firstTimeGame;

    public int brGift;

    public bool island;
    public int cijenaIslanda;

    public int brojMaxZakacenihRibica;
    public float uze;
    public float brzinaKuke;

    public int brojMetaka;
    public float dmg;


    public int brObicna  , brObicnaZelena  , brBob  , brIgla  , brNemo  , brPatrik  , brStruja  , brJelly  , brDuga  , brAjkula  , brZlatna  , brDiver  , brZlato  , brBomb  , brCrvena  , brPodmornica  ;


    public bool killed100   , killed500   , killed2000   , kill3oneShot   , kill5OneShot   , kill10OneShot   , shootAll0Kill   , kill2x   , kill3x   , kill4x   ;
    public bool watch5    , watch10    , watch20    , buyIsland    , have10InAq    , have20InAq    , have40InAq    ;
    public bool explode3InGame    , explode50    , catch5Goldfish    , catch3GoldChests    ;
    public bool travel10000    , upTo50    , upTo100    , upTo200    , upTo50wcf    , upTo100wcf    , upTo200wcf    ;

    public bool c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;
    public bool d1, d2, d3, d4, d5, d6, d7;
    public bool e1, e2, e3, e4;
    public bool g1, g2, g3, g4, g5, g6, g7;

    public int totalTravel;
    public int killed;
    public int bombExplode;

    public int shakePover;

    public bool tutFirstTime;

    public DateTime startTime;

    public Data()
    {
        coins = currency.allCurrency;
        rod1 = BuyRod.rod1;
        rod2 = BuyRod.rod2;
        rod3 = BuyRod.rod3;
        rod4 = BuyRod.rod4;
        rod5 = BuyRod.rod5;
        rod6 = BuyRod.rod6;
        rod7 = BuyRod.rod7;
        rod8 = BuyRod.rod8;

        rod1p = BuyRod.rod1p;
        rod2p = BuyRod.rod2p;
        rod3p = BuyRod.rod3p;
        rod4p = BuyRod.rod4p;
        rod5p = BuyRod.rod5p;
        rod6p = BuyRod.rod6p;
        rod7p = BuyRod.rod8p;
        rod8p = BuyRod.rod7p;

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
        uzi = BuyGun.uzi;
        sniper = BuyGun.sniper;
        rpg = BuyGun.rpg;
        rpgii = BuyGun.rpgii;
        nadeLauncher = BuyGun.nadeLauncher;

        slingp = BuyGun.slingp;
        pistolip = BuyGun.pistolip;
        pistoliip = BuyGun.pistoliip;
        smgp = BuyGun.smgp;
        pumpy1p = BuyGun.pumpy1p;
        pumpy2p = BuyGun.pumpy2p;
        akp = BuyGun.akp;
        nadep = BuyGun.nadep;
        minigunp = BuyGun.minigunp;
        uzip = BuyGun.uzip;
        sniperp = BuyGun.sniperp;
        rpgp = BuyGun.rpgp;
        rpgiip = BuyGun.rpgiip;
        nadeLauncherp = BuyGun.nadeLauncherp;

        ammop = BuyGun.ammop;

        baitp = buyBait.baitp;

        fish1p = BuyFish.fish1p;
        fish2p = BuyFish.fish2p;
        fish3p = BuyFish.fish3p;
        fish4p = BuyFish.fish4p;
        fish5p = BuyFish.fish5p;
        fish6p = BuyFish.fish6p;
        fish7p = BuyFish.fish7p;
        fish8p = BuyFish.fish8p;
        fish9p = BuyFish.fish9p;

        fuelp = BuyFuel.fuelp;
        boostTime = FollowMouse.boostTime;

        firstTimeGame = uslovi.firstTimeGame;

        brGift = giftScript.brGift;
        island = Island.island;
        cijenaIslanda = Island.cijenaIslanda;

        brojMaxZakacenihRibica = CameraMove.brojMaxZakacenihRibica;
        uze = CameraMove.uze;
        brzinaKuke = FollowMouse.moveSpeed;

        brojMetaka = pucajRibu.brojMetaka;
        dmg = uhvatiRibu.dmg;

        brObicna = spawnAkvariji.brObicna;
        brObicnaZelena = spawnAkvariji.brObicnaZelena;
        brBob = spawnAkvariji.brBob;
        brIgla = spawnAkvariji.brIgla;
        brNemo = spawnAkvariji.brNemo;
        brPatrik = spawnAkvariji.brPatrik;
        brStruja = spawnAkvariji.brStruja;
        brJelly = spawnAkvariji.brJelly;
        brDiver = spawnAkvariji.brDiver;
        brDuga = spawnAkvariji.brDuga;
        brAjkula = spawnAkvariji.brAjkula;
        brZlatna = spawnAkvariji.brZlatna;
        brZlato = spawnAkvariji.brZlato;
        brBomb = spawnAkvariji.brBomb;
        brCrvena = spawnAkvariji.brCrvena;
        brPodmornica = spawnAkvariji.brPodmornica;

        killed100 = achivments.killed100;
        killed500 = achivments.killed500;
        killed2000 = achivments.killed2000;
        kill3oneShot = achivments.kill3oneShot;
        kill5OneShot = achivments.kill5OneShot;
        kill10OneShot = achivments.kill10OneShot;
        shootAll0Kill = achivments.shootAll0Kill;
        kill2x = achivments.kill2x;
        kill3x = achivments.kill3x;
        kill4x = achivments.kill4x;
        watch5 = achivments.watch5;
        watch10 = achivments.watch10;
        watch20 = achivments.watch20;
        buyIsland = achivments.buyIsland;
        have10InAq = achivments.have10InAq;
        have20InAq = achivments.have20InAq;
        have40InAq = achivments.have40InAq;
        explode3InGame = achivments.explode3InGame;
        explode50 = achivments.explode50;
        catch3GoldChests = achivments.catch3GoldChests;
        catch5Goldfish = achivments.catch5Goldfish;
        travel10000 = achivments.travel10000;
        upTo50 = achivments.upTo50;
        upTo100 = achivments.upTo100;
        upTo200 = achivments.upTo200;
        upTo50wcf = achivments.upTo50wcf;
        upTo100wcf = achivments.upTo100wcf;
        upTo200wcf = achivments.upTo200wcf;

        c1 = achButtons.c1;
        c2 = achButtons.c2;
        c3 = achButtons.c3;
        c4 = achButtons.c4;
        c5 = achButtons.c5;
        c6 = achButtons.c6;
        c7 = achButtons.c7;
        c8 = achButtons.c8;
        c9 = achButtons.c9;
        c10 = achButtons.c10;

        d1 = achButtonsGuy.d1;
        d2 = achButtonsGuy.d2;
        d3 = achButtonsGuy.d3;
        d4 = achButtonsGuy.d4;
        d5 = achButtonsGuy.d5;
        d6 = achButtonsGuy.d6;
        d7 = achButtonsGuy.d7;

        e1 = achButtonsHook.e1;
        e2 = achButtonsHook.e2;
        e3 = achButtonsHook.e3;
        e4 = achButtonsHook.e4;

        g1 = achButtonsRod.g1;
        g2 = achButtonsRod.g2;
        g3 = achButtonsRod.g3;
        g4 = achButtonsRod.g4;
        g5 = achButtonsRod.g5;
        g6 = achButtonsRod.g6;
        g7 = achButtonsRod.g7;

        totalTravel = CameraMove.totalTravel;
        killed = pucajRibu.killed;
        bombExplode = uhvatiRibu.bombExploded;

        shakePover = ShakeCam.shakePower;

        tutFirstTime = tutPopup.tutFirstTime;

        startTime = coinSystem.startTime;
    }

    //public int brObicna  , brObicnaZelena  , brBob  , brIgla  , brNemo  , brPatrik  , brStruja  , brJelly  , brDuga  , brAjkula  , brZlatna  , brDiver  , brZlato  , brBomb  , brCrvena  , brPodmornica  ;
    ////
    ///static bool rod1 = false, rod2 = false, rod3 = false,rod4 ,rod5 ,rod6 ;
    ///static int rod1p = 10, rod2p = 100, rod3p = 850, rod4p = 3000, rod5p = 8000, rod6p = 14000;
    ///static bool hook1 = false, hook2 = false, hook3 = false,hook4 ,hook5 ,hook6 ;
    // public bool killed100   , killed500   , killed2000   , kill3oneShot   , kill5OneShot   , kill10OneShot   , shootAll0Kill   , kill2x   , kill3x   , kill4x   ;
    // public bool watch5, watch10, watch20, buyIsland, have10InAq, have20InAq, have40InAq;
    // public bool explode3InGame, explode50, catch5Goldfish, catch3GoldChests;
    // public bool travel10000, upTo50, upTo100, upTo200, upTo50wcf, upTo100wcf, upTo200wcf;
    ///
    ///
    ///
    ///
    ///
}
