using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class achCikoDone : MonoBehaviour
{

    public GameObject v1, v2, v3, v4, v5, v6, v7;

    public void Start()
    {
        v1.GetComponent<Text>().text = "DONE: x%";
        v2.GetComponent<Text>().text = "DONE: x%";
        v3.GetComponent<Text>().text = "DONE: x%";
        if(achivments.buyIsland)
        v4.GetComponent<Text>().text = "DONE: YES";
        else
        v4.GetComponent<Text>().text = "DONE: NO";

        if (spawnAkvariji.VratiBrRibica()<10)
        v5.GetComponent<Text>().text = "DONE: "+ spawnAkvariji.VratiBrRibica() * 10+"%";
        else
            v5.GetComponent<Text>().text = "DONE: " + 100 + "%";

        if (spawnAkvariji.VratiBrRibica() < 20)
            v6.GetComponent<Text>().text = "DONE: " + spawnAkvariji.VratiBrRibica() * 5 + "%";
        else
            v6.GetComponent<Text>().text = "DONE: " + 100 + "%";
        if (spawnAkvariji.VratiBrRibica() < 40)
            v7.GetComponent<Text>().text = "DONE: " + spawnAkvariji.VratiBrRibica() * 10/4 + "%";
        else
            v7.GetComponent<Text>().text = "DONE: " + 100 + "%";

    }

}
