using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achDone : MonoBehaviour
{
    public GameObject v, v1, v2, v3, v4;
    int w=0, w1=0, w2=0, w3=0, w4=0;
    void Start()
    {
        if (achivments.killed100)
            w1++;
        if (achivments.killed500)
            w1++;
        if (achivments.killed2000)
            w1++;
        if (achivments.kill3oneShot)
            w1++;
        if (achivments.kill5OneShot)
            w1++;
        if (achivments.kill10OneShot)
            w1++;
        if (achivments.shootAll0Kill)
            w1++;
        if (achivments.kill2x)
            w1++;
        if (achivments.kill3x)
            w1++;
        if (achivments.kill4x)
            w1++;
        if (achivments.watch5)
            w2++;
        if (achivments.watch10)
            w2++;
        if (achivments.watch20)
            w2++;
        if (achivments.buyIsland)
            w2++;
        if (achivments.have10InAq)
            w2++;
        if (achivments.have20InAq)
            w2++;
        if (achivments.have40InAq)
            w2++;
        if (achivments.explode3InGame)
            w3++;
        if (achivments.explode50)
            w3++;
        if (achivments.catch5Goldfish)
            w3++;
        if (achivments.catch3GoldChests)
            w3++;
        if (achivments.travel10000)
            w4++;
        if (achivments.upTo50)
            w4++;
        if (achivments.upTo100)
            w4++;
        if (achivments.upTo200)
            w4++;
        if (achivments.upTo50wcf)
            w4++;
        if (achivments.upTo100wcf)
            w4++;
        if (achivments.upTo200wcf)
            w4++;


        v.GetComponent<Text>().text = "DONE:\n" + (w1 + w2 + w3 + w4) + "/28";
        v1.GetComponent<Text>().text = "" + w1 + "/10";
        v2.GetComponent<Text>().text = "" + w2 + "/7";
        v3.GetComponent<Text>().text = "" + w3 + "/4";
        v4.GetComponent<Text>().text = "" + w4 + "/7";
    }

   
}