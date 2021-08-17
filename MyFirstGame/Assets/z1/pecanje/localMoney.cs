using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class localMoney : MonoBehaviour
{
    static public int localCoins=0;
    public GameObject tekst1;
    public GameObject tekst2;
    public GameObject brMetakaText,brUhvacenihRibica;
    // Start is called before the first frame update
    void Start()
    {
        localCoins = 0;
        updateLocalCoins();
    }

    private void Update()
    {
        updateLocalCoins();
    }

    // Update is called once per frame
    public void updateLocalCoins()
    {
       
        
        tekst1.GetComponent<Text>().text = "" + currency.allCurrency;
        tekst2.GetComponent<Text>().text = "" + localCoins;
        brMetakaText.GetComponent<Text>().text = "" + pucajRibu.brM;
        brUhvacenihRibica.GetComponent<Text>().text = ""+ CameraMove.brojZakacenihRibica +"|"+CameraMove.brojMaxZakacenihUIgri;
    }
}
