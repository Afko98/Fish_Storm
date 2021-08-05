using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Island : MonoBehaviour
{
    public Text text;
     public static bool island = false;
    public static int cijenaIslanda = 10000;

    private void Start()
    {
        if (island)
        {
            KupiIsland();
        }
    }
    public void KupiIsland()
    {
        if (currency.allCurrency >= cijenaIslanda)
        {
            currency.allCurrency -= cijenaIslanda;
            cijenaIslanda = 0;
            island = true;
            text.GetComponent<Text>().text = "ISLAND";
        }
    }

}
