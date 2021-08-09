using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Island : MonoBehaviour
{
    public Animator transition;
    public Text text;
    public static bool island = false;
    public static int cijenaIslanda = 10000;
    public GameObject coins;

    private void Start()
    {
        if (island)
        {
            text.GetComponent<Text>().text = "ISLAND";
        }
    }
    public void KupiIsland()
    {
        if (currency.allCurrency >= cijenaIslanda)
        {
            currency.allCurrency -= cijenaIslanda;
            cijenaIslanda = 0;
            if (island == true)
            {
                SaveSystem.SavePlayer();
                StartCoroutine(LoadLevel(7));
            }
            island = true;
            text.GetComponent<Text>().text = "ISLAND";
            coins.GetComponent<coinCityUpdate>().UpdateCoinsCity();

        }
    }
    IEnumerator LoadLevel(int i)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(i);
    }
}
