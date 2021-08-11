using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uslovi : MonoBehaviour
{
    public static bool pogodjena;
    public static int killedInOneGame,bombInOneGame,zlatnaInOneGame,chestInOneGame;

    private void Start()
    {
        chestInOneGame = 0;
        zlatnaInOneGame = 0;
        bombInOneGame = 0;
        killedInOneGame = 0;
        pogodjena = false;
    }
}
