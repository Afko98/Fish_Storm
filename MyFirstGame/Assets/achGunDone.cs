using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achGunDone : MonoBehaviour
{
    public GameObject v1, v2, v3, v4, v5, v6, v7, v8, v9, v10;

    private void Start()
    {
        if(pucajRibu.killed<100)
        v1.GetComponent<Text>().text = "DONE: "+pucajRibu.killed+"%";
        else
        v1.GetComponent<Text>().text = "DONE: "+100+"%";
        if (pucajRibu.killed < 500)
            v2.GetComponent<Text>().text = "DONE: " + pucajRibu.killed/5 + "%";
        else
            v2.GetComponent<Text>().text = "DONE: " + 100 + "%";
        if (pucajRibu.killed < 2000)
            v3.GetComponent<Text>().text = "DONE: " + pucajRibu.killed/20 + "%";
        else
            v3.GetComponent<Text>().text = "DONE: " + 100 + "%";

        if(achivments.kill3oneShot)
        v4.GetComponent<Text>().text = "DONE: :)";
        else
        v4.GetComponent<Text>().text = "DONE: :(";
        if(achivments.kill5OneShot)
        v5.GetComponent<Text>().text = "DONE: :)";
        else
        v5.GetComponent<Text>().text = "DONE: :(";

        if(achivments.kill10OneShot)
        v6.GetComponent<Text>().text = "DONE: :)";
        else
        v6.GetComponent<Text>().text = "DONE: :(";
        if(achivments.shootAll0Kill)
        v7.GetComponent<Text>().text = "DONE: :)";
        else
        v7.GetComponent<Text>().text = "DONE: :(";
        if(achivments.kill2x)
        v8.GetComponent<Text>().text = "DONE: :)";
        else
        v8.GetComponent<Text>().text = "DONE: :(";
        if(achivments.kill3x)
        v9.GetComponent<Text>().text = "DONE: :)";
        else
        v9.GetComponent<Text>().text = "DONE: :(";
        if(achivments.kill4x)
        v10.GetComponent<Text>().text = "DONE: :)";
        else
        v10.GetComponent<Text>().text = "DONE: :(";
    }

}
