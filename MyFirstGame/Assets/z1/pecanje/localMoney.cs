using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class localMoney : MonoBehaviour
{
    static public int localCoins=0;
    public GameObject tekst;
    // Start is called before the first frame update
    void Start()
    {
        localCoins = 0;
        updateLocalCoins();
    }

    // Update is called once per frame
    public void updateLocalCoins()
    {
        tekst.GetComponent<Text>().text = "" + localCoins;
    }
}
