using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SceneSwitcher : MonoBehaviour
{
    public Animator transition;
    public static bool uslov=false;

    public void DodajLocalCoins()
    {
        currency.allCurrency += localMoney.localCoins;
        giftScript.brGift += uslovi.giftsInGame;
    }
    public void Menu()
    {
        StartCoroutine(LoadLevel(0));
    }
    public void CityLoad()
    {

        string path = Application.persistentDataPath + "/data.thesenuts";
        if (File.Exists(path)) { 
            Data data = SaveSystem.LoadPlayer();


            currency.allCurrency=data.coins;
            BuyRod.rod1=data.rod1;
            BuyRod.rod2=data.rod2;
            BuyRod.rod3=data.rod3;
            BuyRod.rod4=data.rod4;
            BuyRod.rod5=data.rod5;
            BuyRod.rod6=data.rod6;
            BuyRod.rod7=data.rod7;
            BuyRod.rod8=data.rod8;

            BuyRod.rod1p=data.rod1p;
            BuyRod.rod2p=data.rod2p;
            BuyRod.rod3p=data.rod3p;
            BuyRod.rod4p=data.rod4p;
            BuyRod.rod5p=data.rod5p;
            BuyRod.rod6p=data.rod6p;
            BuyRod.rod8p=data.rod7p;
            BuyRod.rod7p=data.rod8p;
            
            BuyHook.hook1=data.hook1;
            BuyHook.hook2=data.hook2;
            BuyHook.hook3=data.hook3;
            BuyHook.hook4=data.hook4;
            BuyHook.hook5=data.hook5;
            BuyHook.hook6=data.hook6;

            BuyHook.hook1p=data.hook1p;
            BuyHook.hook2p=data.hook2p;
            BuyHook.hook3p=data.hook3p;
            BuyHook.hook4p=data.hook4p;
            BuyHook.hook5p=data.hook5p;
            BuyHook.hook6p=data.hook6p;

            BuyGun.sling=data.sling;
            BuyGun.pistoli=data.pistoli;
            BuyGun.pistolii=data.pistolii;
            BuyGun.smg=data.smg;
            BuyGun.pumpy1=data.pumpy1;
            BuyGun.pumpy2=data.pumpy2;
            BuyGun.ak=data.ak;
            BuyGun.nade=data.nade;
            BuyGun.minigun=data.minigun;
            BuyGun.uzi=data.uzi;
            BuyGun.sniper=data.sniper;
            BuyGun.rpg=data.rpg;
            BuyGun.rpgii=data.rpgii;
            BuyGun.nadeLauncher=data.nadeLauncher;

            BuyGun.slingp=data.slingp;
            BuyGun.pistolip=data.pistolip;
            BuyGun.pistoliip=data.pistoliip;
            BuyGun.smgp=data.smgp;
            BuyGun.pumpy1p=data.pumpy1p;
            BuyGun.pumpy2p=data.pumpy2p;
            BuyGun.akp=data.akp;
            BuyGun.nadep=data.nadep;
            BuyGun.minigunp=data.minigunp;
            BuyGun.uzip=data.uzip;
            BuyGun.sniperp=data.sniperp;
            BuyGun.rpgp=data.rpgp;
            BuyGun.rpgiip=data.rpgiip;
            BuyGun.nadeLauncherp=data.nadeLauncherp;

            buyBait.baitp=data.baitp;

            BuyFish.fish1p=data.fish1p;
            BuyFish.fish2p=data.fish2p;
            BuyFish.fish3p=data.fish3p;
            BuyFish.fish4p=data.fish4p;
            BuyFish.fish5p=data.fish5p;
            BuyFish.fish6p=data.fish6p;
            BuyFish.fish7p=data.fish7p;
            BuyFish.fish8p=data.fish8p;
            BuyFish.fish9p=data.fish9p;

            BuyFuel.fuelp=data.fuelp;
            FollowMouse.boostTime=data.boostTime;

            uslovi.firstTimeGame=data.firstTimeGame;

            giftScript.brGift=data.brGift;
            Island.island=data.island;
            Island.cijenaIslanda=data.cijenaIslanda;

            CameraMove.brojMaxZakacenihRibica=data.brojMaxZakacenihRibica;
            CameraMove.uze=data.uze;
            FollowMouse.moveSpeed=data.brzinaKuke;

            pucajRibu.brojMetaka=data.brojMetaka;
            uhvatiRibu.dmg=data.dmg; 

            spawnAkvariji.brObicna=data.brObicna;
            spawnAkvariji.brObicnaZelena=data.brObicnaZelena;
            spawnAkvariji.brBob=data.brBob;
            spawnAkvariji.brIgla=data.brIgla;
            spawnAkvariji.brNemo=data.brNemo;
            spawnAkvariji.brPatrik=data.brPatrik;
            spawnAkvariji.brStruja=data.brStruja;
            spawnAkvariji.brJelly=data.brJelly;
            spawnAkvariji.brDiver=data.brDiver;
            spawnAkvariji.brDuga=data.brDuga;
            spawnAkvariji.brAjkula=data.brAjkula;
            spawnAkvariji.brZlatna=data.brZlatna;
            spawnAkvariji.brZlato=data.brZlato;
            spawnAkvariji.brBomb=data.brBomb;
            spawnAkvariji.brCrvena=data.brCrvena;
            spawnAkvariji.brPodmornica=data.brPodmornica;

            achivments.killed100=data.killed100;
            achivments.killed500=data.killed500;
            achivments.killed2000 = data.killed2000;
            achivments.kill3oneShot=data.kill3oneShot;
            achivments.kill5OneShot=data.kill5OneShot;
            achivments.kill10OneShot=data.kill10OneShot;
            achivments.shootAll0Kill=data.shootAll0Kill;
            achivments.kill2x=data.kill2x;
            achivments.kill3x=data.kill3x;
            achivments.kill4x=data.kill4x;
            achivments.watch5=data.watch5;
            achivments.watch10=data.watch10;
            achivments.watch20=data.watch20;
            achivments.buyIsland=data.buyIsland;
            achivments.have10InAq=data.have10InAq;
            achivments.have20InAq=data.have20InAq;
            achivments.have40InAq=data.have40InAq;
            achivments.explode3InGame=data.explode3InGame;
            achivments.explode50=data.explode50;
            achivments.catch3GoldChests=data.catch3GoldChests;
            achivments.catch5Goldfish=data.catch5Goldfish;
            achivments.travel10000=data.travel10000;
            achivments.upTo50=data.upTo50;
            achivments.upTo100=data.upTo100;
            achivments.upTo200=data.upTo200;
            achivments.upTo50wcf=data.upTo50wcf;
            achivments.upTo100wcf=data.upTo100wcf;
            achivments.upTo200wcf=data.upTo200wcf;

            achButtons.c1=data.c1;
            achButtons.c2=data.c2;
            achButtons.c3=data.c3;
            achButtons.c4=data.c4;
            achButtons.c5=data.c5;
            achButtons.c6=data.c6;
            achButtons.c7=data.c7;
            achButtons.c8=data.c8;
            achButtons.c9=data.c9;
            achButtons.c10=data.c10;

            achButtonsGuy.d1=data.d1;
            achButtonsGuy.d2=data.d2;
            achButtonsGuy.d3=data.d3;
            achButtonsGuy.d4=data.d4;
            achButtonsGuy.d5=data.d5;
            achButtonsGuy.d6=data.d6;
            achButtonsGuy.d7=data.d7;

            achButtonsHook.e1=data.e1;
            achButtonsHook.e2=data.e2;
            achButtonsHook.e3=data.e3;
            achButtonsHook.e4=data.e4;

            achButtonsRod.g1=data.g1;
            achButtonsRod.g2=data.g2;
            achButtonsRod.g3=data.g3;
            achButtonsRod.g4=data.g4;
            achButtonsRod.g5=data.g5;
            achButtonsRod.g6=data.g6;
            achButtonsRod.g7=data.g7;

            CameraMove.totalTravel=data.totalTravel;
            pucajRibu.killed=data.killed;
            uhvatiRibu.bombExploded=data.bombExplode;

            ShakeCam.shakePower=data.shakePover;

            tutPopup.tutFirstTime = data.tutFirstTime;

            coinSystem.startTime=data.startTime;

            SceneSwitcher.uslov = true;

        }
        uslov = true;
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        StartCoroutine(LoadLevel(1));
    }
    public void City()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        StartCoroutine(LoadLevel(1));
    }
    public void startGame()
    {
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(2);
    }

    public void shopGun()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(3);
    }
    public void shopMamac()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(4);
    }
    
    public void shopKuka()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(5);
    }
    public void shopRod()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(6);
    }
    public void island()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        StartCoroutine(LoadLevel(7));
    }
    public void akvariji()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        StartCoroutine(LoadLevel(8));
    }
    public void shopFish()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        StartCoroutine(LoadLevel(9));
    }
    public void ach()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        StartCoroutine(LoadLevel(10));
    }
    public void achGun()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(11);
    }
    public void achGuy()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(12);
    }
    public void achHook()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(13);
    }
    public void achRod()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(14);
    }
    public void buyBoost()
    {
        SaveSystem.SavePlayer();
        GameObject.FindGameObjectWithTag("soundEff").GetComponent<soundEffScript>().PlayMenuNavig();
        SceneManager.LoadScene(15);
    }

    IEnumerator LoadLevel(int i)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(i);
    }
}