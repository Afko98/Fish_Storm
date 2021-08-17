using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFuel : MonoBehaviour
{

    public static int  fuelp = 200;
    public Text v10;
    public GameObject coinupdate;
    public Text text; //ADDS 1 MORE SHOOT
    //YOU NOW HAVE: x SHOOTS

    private void Start()
    {
       
        v10.GetComponent<Text>().text = "" + fuelp;
        text.GetComponent<Text>().text = "YOU CAN BOOST THE HOOK FOR " + FollowMouse.boostTime + " SECONDS";

    }

    public void buyFuel()
    {
        if (currency.allCurrency >= fuelp)
        {
            currency.allCurrency -= fuelp;
            if (fuelp < 1000)
                fuelp *= 4;
            else
                fuelp *= 2;

            FollowMouse.boostTime += 1;
            v10.GetComponent<Text>().text = "" + fuelp;
            text.GetComponent<Text>().text = "YOU CAN BOOST THE HOOK FOR " + FollowMouse.boostTime + " SECONDS";
            coinupdate.GetComponent<allcoinsdisplay>().Koliko();
        }
    }
    


}
