
using UnityEngine;
using UnityEngine.UI;

public class coinCityUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "" + currency.allCurrency;
    }

    
}
