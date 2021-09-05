using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyBait: MonoBehaviour
{

    public static int baitp = 10;
    public GameObject tekst;
    public GameObject v,coinupdate;

    private void Start()
    {
        tekst.GetComponent<Text>().text = "ADDS 3 MORE BAITS\n" + "YOU CAN CATCH UP TO " + CameraMove.brojMaxZakacenihRibica + " FISH";
        v.GetComponent<Text>().text = "" + baitp;
    }

    //w1.GetComponent<Text>().text = "IN USE";
    public void buybait()
    {
        if (currency.allCurrency >= baitp)
        {
            currency.allCurrency -= baitp;
            if (baitp < 1000)
                baitp *= 3;
            else if (baitp >= 1000 && baitp < 20000)
                baitp = (int)(baitp * 1.4f);
            else
                baitp = (int)(baitp * 1.1f);
            CameraMove.brojMaxZakacenihRibica+=3;
            v.GetComponent<Text>().text = "" + baitp;
            tekst.GetComponent<Text>().text = "ADDS 3 MORE BAITS\n"+"YOU CAN CATCH UP TO "+CameraMove.brojMaxZakacenihRibica+" FISH";
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
}
