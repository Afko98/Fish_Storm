using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Animator transition;
    public void Menu()
    {
        StartCoroutine(LoadLevel(0));
    }
    public void City()
    {
        StartCoroutine(LoadLevel(1));
    }
    public void startGame()
    {
        StartCoroutine(LoadLevel(2));
    }

    public void shopGun()
    {
        StartCoroutine(LoadLevel(3));
    }
    public void shopMamac()
    {
        StartCoroutine(LoadLevel(4));
    }
    
    public void shopKuka()
    {
        StartCoroutine(LoadLevel(5));
    }
    public void shopRod()
    {
        StartCoroutine(LoadLevel(6));
    }

    IEnumerator LoadLevel(int i)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(i);
    }
}