using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achHookDone : MonoBehaviour
{
    public GameObject v1, v2, v3, v4;

    private void Start()
    {
        if (achivments.explode3InGame)
            v1.GetComponent<Text>().text = "DONE: :)";
        else    
        v1.GetComponent<Text>().text = "DONE: :(";

        if(uhvatiRibu.bombExploded<50)
            v2.GetComponent<Text>().text = "DONE: "+uhvatiRibu.bombExploded*2+"%";
        else
            v2.GetComponent<Text>().text = "DONE: 100%";
        if(achivments.catch5Goldfish)
            v3.GetComponent<Text>().text = "DONE: :)";
        else    
        v3.GetComponent<Text>().text = "DONE: :(";
        if(achivments.catch3GoldChests)
            v4.GetComponent<Text>().text = "DONE: :)";
        else    
        v4.GetComponent<Text>().text = "DONE: :(";

    }
}
