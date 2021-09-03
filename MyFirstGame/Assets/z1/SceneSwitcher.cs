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


            currency.allCurrency = data.coins;
            BuyRod.rod1 = data.rod1;
            BuyRod.rod2 = data.rod2;
            BuyRod.rod3 = data.rod3;
            BuyRod.rod4 = data.rod4;
            BuyRod.rod5 = data.rod5;
            BuyRod.rod6 = data.rod6;

            BuyRod.rod1p = data.rod1p;
            BuyRod.rod2p = data.rod2p;
            BuyRod.rod3p = data.rod3p;
            BuyRod.rod4p = data.rod4p;
            BuyRod.rod5p = data.rod5p;
            BuyRod.rod6p = data.rod6p;

            BuyHook.hook1 = data.hook1;
            BuyHook.hook2 = data.hook2;
            BuyHook.hook3 = data.hook3;
            BuyHook.hook4 = data.hook4;
            BuyHook.hook5 = data.hook5;
            BuyHook.hook6 = data.hook6;

            BuyHook.hook1p = data.hook1p;
            BuyHook.hook2p = data.hook2p;
            BuyHook.hook3p = data.hook3p;
            BuyHook.hook4p = data.hook4p;
            BuyHook.hook5p = data.hook5p;
            BuyHook.hook6p = data.hook6p;

            BuyGun.sling = data.sling;
            BuyGun.pistoli = data.pistoli;
            BuyGun.pistolii = data.pistolii;
            BuyGun.smg = data.smg;
            BuyGun.pumpy1 = data.pumpy1;
            BuyGun.pumpy2 = data.pumpy2;
            BuyGun.ak = data.ak;
            BuyGun.nade = data.nade;
            BuyGun.minigun = data.minigun;

            BuyGun.slingp = data.slingp;
            BuyGun.pistolip = data.pistolip;
            BuyGun.pistoliip = data.pistoliip;
            BuyGun.smgp = data.smgp;
            BuyGun.pumpy1p = data.pumpy1p;
            BuyGun.pumpy2p = data.pumpy2p;
            BuyGun.akp = data.akp;
            BuyGun.nadep = data.nadep;
            BuyGun.minigunp = data.minigunp;

            buyBait.wormi = data.wormi;
            buyBait.wormii = data.wormii;
            buyBait.wormiii = data.wormiii;

            buyBait.wormip = data.wormip;
            buyBait.wormiip = data.wormiip;
            buyBait.wormiiip = data.wormiiip;

            CameraMove.brojMaxZakacenihRibica = data.brojMaxZakacenihRibica;
            CameraMove.uze = data.uze;

            FollowMouse.moveSpeed = data.brzinaKuke;

            pucajRibu.brojMetaka = data.brojMetaka;
            uhvatiRibu.dmg = data.dmg;

            SceneSwitcher.uslov = true;

        }
        uslov = true;

        StartCoroutine(LoadLevel(1));
    }
    public void City()
    {
        SaveSystem.SavePlayer();
        StartCoroutine(LoadLevel(1));
    }
    public void startGame()
    {

        SceneManager.LoadScene(2);
    }

    public void shopGun()
    {

        SceneManager.LoadScene(3);
    }
    public void shopMamac()
    {
        SceneManager.LoadScene(4);
    }
    
    public void shopKuka()
    {

        SceneManager.LoadScene(5);
    }
    public void shopRod()
    {

        SceneManager.LoadScene(6);
    }
    public void island()
    {
        StartCoroutine(LoadLevel(7));
    }
    public void akvariji()
    {
        StartCoroutine(LoadLevel(8));
    }
    public void shopFish()
    {
        StartCoroutine(LoadLevel(9));
    }
    public void ach()
    {
        StartCoroutine(LoadLevel(10));
    }
    public void achGun()
    {
        SceneManager.LoadScene(11);
    }
    public void achGuy()
    {
        SceneManager.LoadScene(12);
    }
    public void achHook()
    {
        SceneManager.LoadScene(13);
    }
    public void achRod()
    {
        SceneManager.LoadScene(14);
    }
    public void buyBoost()
    {
        SceneManager.LoadScene(15);
    }

    IEnumerator LoadLevel(int i)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(i);
    }
}