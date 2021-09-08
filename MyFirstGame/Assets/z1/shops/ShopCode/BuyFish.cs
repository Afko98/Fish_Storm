using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFish : MonoBehaviour
{
    
    public static int fish1p = 150, fish2p = 150, fish3p = 150, fish4p = 150, fish5p = 150, fish6p = 150,fish7p=150,fish8p=150,fish9p=150;
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
            fish1p = (int)(fish1p*1.6f);

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
            fish2p = (int)(fish2p * 1.6f);

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
            fish3p = (int)(fish3p * 1.8f);

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
            fish4p = (int)(fish4p * 1.8f);

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
            fish5p = (int)(fish5p * 1.8f);

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
            fish6p = (int)(fish6p * 2.2f);

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
            fish7p = (int)(fish7p * 2.2f);

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
            fish8p = (int)(fish8p * 2.4f);

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
            fish9p = (int)(fish9p * 2.4f);

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
