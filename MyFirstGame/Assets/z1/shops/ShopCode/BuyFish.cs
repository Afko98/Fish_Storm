using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFish : MonoBehaviour
{
    
    public static int fish1p = 100, fish2p = 100, fish3p = 100, fish4p = 100, fish5p = 100, fish6p = 100,fish7p=100,fish8p=100,fish9p=100;
    public Text v1, v2, v3, v4, v5, v6,v7,v8,v9;
    public GameObject coinupdate;

    private void Start()
    {
        v1.GetComponent<Text>().text = "" + fish1p;
        v2.GetComponent<Text>().text = "" + fish2p;
        v3.GetComponent<Text>().text = "" + fish3p;
        v4.GetComponent<Text>().text = "" + fish4p;
        v5.GetComponent<Text>().text = "" + fish5p;
        v6.GetComponent<Text>().text = "" + fish6p;
        v7.GetComponent<Text>().text = "" + fish7p;
        v8.GetComponent<Text>().text = "" + fish8p;
        v9.GetComponent<Text>().text = "" + fish9p;

        coinupdate.GetComponent<allcoinsdisplay>().Koliko();
    }

    //v1.GetComponent<Text>().text = "IN USE";
    public void buyfish1()
    {
        if (currency.allCurrency >= fish1p)
        {
            currency.allCurrency -= fish1p;
            fish1p *= 3;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brObicna++;


            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyfish2()
    {
        if (currency.allCurrency >= fish2p)
        {
            currency.allCurrency -= fish2p;
            fish2p *= 3;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brStruja++;


            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyfish3()
    {
        if (currency.allCurrency >= fish3p)
        {
            currency.allCurrency -= fish3p;
            fish3p*=3 ;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brJelly++;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyfish4()
    {
        if (currency.allCurrency >= fish4p)
        {
            currency.allCurrency -= fish4p;
            fish4p *= 4;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brDuga++;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyfish5()
    {
        if (currency.allCurrency >= fish5p)
        {
            currency.allCurrency -= fish5p;
            fish5p *= 4;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brAjkula++;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyfish6()
    {
        if (currency.allCurrency >= fish6p)
        {
            currency.allCurrency -= fish6p;
            fish6p *= 4;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brZlato++;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyfish7()
    {
        if (currency.allCurrency >= fish7p)
        {
            currency.allCurrency -= fish7p;
            fish7p *= 5;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brBomb++;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyfish8()
    {
        if (currency.allCurrency >= fish8p)
        {
            currency.allCurrency -= fish8p;
            fish8p *= 5;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brZlatna++;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyfish9()
    {
        if (currency.allCurrency >= fish9p)
        {
            currency.allCurrency -= fish9p;
            fish9p *= 5;

            v1.GetComponent<Text>().text = "" + fish1p;
            v2.GetComponent<Text>().text = "" + fish2p;
            v3.GetComponent<Text>().text = "" + fish3p;
            v4.GetComponent<Text>().text = "" + fish4p;
            v5.GetComponent<Text>().text = "" + fish5p;
            v6.GetComponent<Text>().text = "" + fish6p;
            v7.GetComponent<Text>().text = "" + fish7p;
            v8.GetComponent<Text>().text = "" + fish8p;
            v9.GetComponent<Text>().text = "" + fish9p;
            spawnAkvariji.brCrvena++;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

}
