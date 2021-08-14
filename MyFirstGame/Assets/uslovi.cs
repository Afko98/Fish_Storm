using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uslovi : MonoBehaviour
{
    public static bool pogodjena;
    public static int killedInOneGame,bombInOneGame,zlatnaInOneGame,chestInOneGame;
    public static bool firstTimeGame = true;
    public GameObject tut,startScreen;

    private void Start()
    {
        chestInOneGame = 0;
        zlatnaInOneGame = 0;
        bombInOneGame = 0;
        killedInOneGame = 0;
        pogodjena = false;

        if (firstTimeGame)
        {
            startScreen.SetActive(false);
            firstTimeGame = false;
        }
        else if (!firstTimeGame)
            tut.SetActive(false);

    }

    public void ugasi()
    {
        tut.SetActive(false);
        startScreen.SetActive(true);
    }



}
