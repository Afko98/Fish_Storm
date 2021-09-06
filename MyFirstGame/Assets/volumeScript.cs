using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeScript : MonoBehaviour
{
   public Sprite son, soff;
    static GameObject music;
    public GameObject musicDugme;
    static bool a = true;
    private void Start()
    {
        music = GameObject.FindGameObjectWithTag("music");
        if(a)
            musicDugme.GetComponent<Image>().sprite = son;
        else
            musicDugme.GetComponent<Image>().sprite = soff;
    }
    public void IskljuciMuziku()
    {
        if (a)
        {
            musicDugme.GetComponent<Image>().sprite = soff;
            foreach (AudioSource x in music.GetComponents<AudioSource>())
                x.volume = 0.001f;
            a = false;

        }
        else if (!a)
        {
            musicDugme.GetComponent<Image>().sprite = son;
            foreach (AudioSource x in music.GetComponents<AudioSource>())
                x.volume = 1f;
            a = true;
        }
    }
}
