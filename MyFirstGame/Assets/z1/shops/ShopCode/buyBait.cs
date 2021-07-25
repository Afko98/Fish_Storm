using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyBait: MonoBehaviour
{
    static bool wormi=false , wormii=false , wormiii=false ;
    static int wormip = 20, wormiip = 300, wormiiip = 1200;
    public GameObject w1, w2, w3,coinupdate;

    private void Start()
    {
        if (wormi)
            buyWormI();
        if (wormii)
            buyWormII();
        if (wormiii)
            buyWormIII();
    }

    //w1.GetComponent<Text>().text = "IN USE";
    public void buyWormI()
    {
            if (currency.allCurrency >= wormip)
            {
            currency.allCurrency -= wormip;
                wormip = 0;
            wormi = true;
            wormii = false;
            wormiii = false;
            w1.GetComponent<Text>().text = "IN USE";
            w2.GetComponent<Text>().text = ""+wormiip;
            w3.GetComponent<Text>().text = ""+wormiiip;
            CameraMove.brojMaxZakacenihRibica = 10;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
            }
        }
   public void buyWormII()
    {
        if (currency.allCurrency >= wormiip)
        {
            currency.allCurrency -= wormiip;
            wormiip = 0;
            wormi = false;
            wormii = true;
            wormiii = false;
            w1.GetComponent<Text>().text = ""+wormip;
            w2.GetComponent<Text>().text = "IN USE";
            w3.GetComponent<Text>().text = ""+wormiiip;
            CameraMove.brojMaxZakacenihRibica = 15;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyWormIII()
    {
        if (currency.allCurrency >= wormiiip)
        {
            currency.allCurrency -= wormiiip;
            wormiiip = 0;
            wormi = false;
            wormii = false;
            wormiii = true;
            w1.GetComponent<Text>().text = ""+wormip;
            w2.GetComponent<Text>().text = ""+wormiip;
            w3.GetComponent<Text>().text = "IN USE";
            CameraMove.brojMaxZakacenihRibica = 20;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

}
