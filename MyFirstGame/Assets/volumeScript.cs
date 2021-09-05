using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeScript : MonoBehaviour
{
   public Sprite son, soff;
    GameObject music;
    public GameObject musicDugme;
    private void Start()
    {
        music = GameObject.FindGameObjectWithTag("music");
    }
    public void IskljuciMuziku()
    {
        if (music.activeSelf)
        {
            musicDugme.GetComponent<Image>().sprite = soff;
            music.SetActive(false);
            
        }
        else if (!music.activeSelf)
        { 
            musicDugme.GetComponent<Image>().sprite = son;
            music.SetActive(true);
           
        }
    }
}
