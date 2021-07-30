using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyRod : MonoBehaviour
{
    static bool rod1 = false, rod2 = false, rod3 = false,rod4=false,rod5=false,rod6=false;
    static int rod1p = 10, rod2p = 100, rod3p = 850, rod4p=3000, rod5p=8000,rod6p=14000;
    public Text v1, v2, v3,v4,v5,v6;
    public GameObject coinupdate;

    private void Start()
    {
        if (rod1)
            buyrod1();
        if (rod2)
            buyrod2();
        if (rod3)
            buyrod3();
        if (rod4)
            buyrod4();
        if (rod5)
            buyrod5();
        if (rod6)
            buyrod6();
    }

    //v1.GetComponent<Text>().text = "IN USE";
    public void buyrod1()
    {
        if (currency.allCurrency >= rod1p)
        {
            currency.allCurrency -= rod1p;
            rod1p = 0;
            rod1 = true;
            rod2 = false;
            rod3 = false;
            rod4 = false;
            rod5 = false;
            rod6 = false;
            v1.GetComponent<Text>().text = "IN USE";
            v2.GetComponent<Text>().text = "" + rod2p;
            v3.GetComponent<Text>().text = "" + rod3p;
            v4.GetComponent<Text>().text = "" + rod4p;
            v5.GetComponent<Text>().text = "" + rod5p;
            v6.GetComponent<Text>().text = "" + rod6p;
            CameraMove.uze = 50;

            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyrod2()
    {
        if (currency.allCurrency >= rod2p)
        {
            currency.allCurrency -= rod2p;
            rod2p = 0;
            rod1 = false;
            rod2 = true;
            rod3 = false;
            rod4 = false;
            rod5 = false;
            rod6 = false;
            v1.GetComponent<Text>().text = "" + rod1p;
            v2.GetComponent<Text>().text = "IN USE";
            v3.GetComponent<Text>().text = "" + rod3p;
            v4.GetComponent<Text>().text = "" + rod4p;
            v5.GetComponent<Text>().text = "" + rod5p;
            v6.GetComponent<Text>().text = "" + rod6p;
         

            CameraMove.uze = 100;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyrod3()
    {
        if (currency.allCurrency >= rod3p)
        {
            currency.allCurrency -= rod3p;
            rod3p = 0;
            rod1 = false;
            rod2 = false;
            rod3 = true;
            rod4 = false;
            rod5 = false;
            rod6 = false;
            v1.GetComponent<Text>().text = "" + rod1p;
            v2.GetComponent<Text>().text = "" + rod2p;
            v3.GetComponent<Text>().text = "IN USE";
            v4.GetComponent<Text>().text = "" + rod4p;
            v5.GetComponent<Text>().text = "" + rod5p;
            v6.GetComponent<Text>().text = "" + rod6p;
         

            CameraMove.uze = 150;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyrod4()
    {
        if (currency.allCurrency >= rod4p)
        {
            currency.allCurrency -= rod4p;
            rod4p = 0;
            rod2 = false;
            rod3 = false;
            rod4 = true;
            rod5 = false;
            rod6 = false;
            v1.GetComponent<Text>().text = "" + rod1p;
            v2.GetComponent<Text>().text = "" + rod2p;
            v3.GetComponent<Text>().text = "" + rod3p;
            v4.GetComponent<Text>().text = "IN USE";
            v5.GetComponent<Text>().text = "" + rod5p;
            v6.GetComponent<Text>().text = "" + rod6p;
            

            CameraMove.uze = 220;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyrod5()
    {
        if (currency.allCurrency >= rod5p)
        {
            currency.allCurrency -= rod5p;
            rod5p = 0;
            rod2 = false;
            rod3 = false;
            rod4 = false;
            rod5 = true;
            rod6 = false;
            v1.GetComponent<Text>().text = "" + rod1p;
            v2.GetComponent<Text>().text = "" + rod2p;
            v3.GetComponent<Text>().text = "" + rod3p;
            v4.GetComponent<Text>().text = "" + rod4p;
            v5.GetComponent<Text>().text = "IN USE";
            v6.GetComponent<Text>().text = "" + rod6p;
            

            CameraMove.uze = 310;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void buyrod6()
    {
        if (currency.allCurrency >= rod6p)
        {
            currency.allCurrency -= rod6p;
            rod6p = 0;
            rod2 = false;
            rod3 = false;
            rod4 = false;
            rod5 = false;
            rod6 = true;
            v1.GetComponent<Text>().text = "" + rod1p;
            v2.GetComponent<Text>().text = "" + rod2p;
            v3.GetComponent<Text>().text = "" + rod3p;
            v4.GetComponent<Text>().text = "" + rod4p;
            v5.GetComponent<Text>().text = "" + rod5p;
            v6.GetComponent<Text>().text = "IN USE";
            

            CameraMove.uze = 400;
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

}
