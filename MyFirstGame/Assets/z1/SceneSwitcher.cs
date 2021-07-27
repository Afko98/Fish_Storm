using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void City()
    {
        SceneManager.LoadScene(1);
    }
    public void startGame()
    {
        SceneManager.LoadScene(2);
    }

    public void shopGun()
    {
        SceneManager.LoadScene(3);
    }
    public void shopMamac()
    {
        SceneManager.LoadScene(4);
    }
    
    public void shopKuka()
    {
        SceneManager.LoadScene(5);
    }


}