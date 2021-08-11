using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achButtons : MonoBehaviour
{
    public Text v1, v2, v3, v4, v5, v6, v7, v8, v9, v10;
    public static bool c1 = false, c2 = false, c3 = false, c4 = false, c5 = false, c6 = false, c7 = false, c8 = false, c9 = false, c10 = false;
    public GameObject coinUpdate;

    private void Start()
    {
        if (c1)
            v1.GetComponent<Text>().text = "DONE";
        if (c2)
            v2.GetComponent<Text>().text = "DONE";
        if (c3)
            v3.GetComponent<Text>().text = "DONE";
        if (c4)
            v4.GetComponent<Text>().text = "DONE";
        if (c5)
            v5.GetComponent<Text>().text = "DONE";
        if (c6)
            v6.GetComponent<Text>().text = "DONE";
        if (c7)
            v7.GetComponent<Text>().text = "DONE";
        if (c8)
            v8.GetComponent<Text>().text = "DONE";
        if (c9)
            v9.GetComponent<Text>().text = "DONE";
        if (c10)
            v10.GetComponent<Text>().text = "DONE";
    }

    public void kill100()
    {
        if (achivments.killed100 && !c1)
        {
            currency.allCurrency += 600;
            v1.GetComponent<Text>().text = "DONE";
            c1 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void kill500()
    {

        if (achivments.killed500 && !c2)
        {
            currency.allCurrency += 1500;
            v2.GetComponent<Text>().text = "DONE";
            c2 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void kill2000()
    {
        if (achivments.killed2000 && !c3)
        {
            currency.allCurrency += 4000;
            v3.GetComponent<Text>().text = "DONE";
            c3 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }

    public void kill3OneShot()
    {
        if (achivments.kill3oneShot && !c4)
        {
            currency.allCurrency += 400;
            v4.GetComponent<Text>().text = "DONE";
            c4 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void kill5OneShoot()
    {
        if (achivments.kill5OneShot && !c5)
        {
            currency.allCurrency += 1000;
            v5.GetComponent<Text>().text = "DONE";
            c5 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void kill10OneShot()
    {
        if (achivments.kill10OneShot && !c6)
        {
            currency.allCurrency += 2000;
            v6.GetComponent<Text>().text = "DONE";
            c6 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void shootAll0Kill()
    {
        if (achivments.shootAll0Kill && !c7)
        {
            currency.allCurrency += 150;
            v7.GetComponent<Text>().text = "DONE";
            c7 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void kill2x()
    {
        if (achivments.kill2x && !c8)
        {
            currency.allCurrency += 500;
            v8.GetComponent<Text>().text = "DONE";
            c8 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void kill3x()
    {
        if (achivments.kill3x && !c9)
        {
            currency.allCurrency += 1000;
            v9.GetComponent<Text>().text = "DONE";
            c9 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    public void kill4x()
    {
        if (achivments.kill4x && !c10)
        {
            currency.allCurrency += 2000;
            v10.GetComponent<Text>().text = "DONE";
            c10 = true;
            coinUpdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }


}
