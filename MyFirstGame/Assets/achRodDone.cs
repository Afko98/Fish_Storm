using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achRodDone : MonoBehaviour
{
    public GameObject v1, v2, v3, v4, v5, v6, v7;

    private void Start()
    {
        if(CameraMove.totalTravel<10000)
        v1.GetComponent<Text>().text = "DONE: "+CameraMove.totalTravel/100+"%";
        else
        v1.GetComponent<Text>().text = "DONE: "+100+"%";
        if (achivments.upTo50)
        v2.GetComponent<Text>().text = "DONE: :)";
        else
        v2.GetComponent<Text>().text = "DONE: :(";
        if(achivments.upTo100)
        v3.GetComponent<Text>().text = "DONE: :)";
        else
        v3.GetComponent<Text>().text = "DONE: :(";
        if(achivments.upTo200)
        v4.GetComponent<Text>().text = "DONE: :)";
        else
        v4.GetComponent<Text>().text = "DONE: :(";
        if(achivments.upTo50wcf)
        v5.GetComponent<Text>().text = "DONE: :)";
        else
        v5.GetComponent<Text>().text = "DONE: :(";
        if(achivments.upTo100wcf)
        v6.GetComponent<Text>().text = "DONE: :)";
        else
        v6.GetComponent<Text>().text = "DONE: :(";
        if(achivments.upTo200wcf)
        v7.GetComponent<Text>().text = "DONE: :)";
        else
        v7.GetComponent<Text>().text = "DONE: :(";
    }
}
