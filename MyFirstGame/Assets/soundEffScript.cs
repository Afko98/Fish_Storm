using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffScript : MonoBehaviour
{

    public AudioSource bombExplosion, giftOpen, shoot, uniqumGift,menuNavig;
    int random, playing;
    public static music musicInstance;

    // Start is called before the first frame update
    
    

    public void PlayBombExsplosion()
    {
        bombExplosion.Play();
    }
    
    public void PlayGiftOpen()
    {
        giftOpen.Play();
    }
        
    public void PlayShoot()
    {
        shoot.Play();
    }
    
    public void PlayUnique()
    {
        uniqumGift.Play();
    }

    public void PlayMenuNavig()
    {
        menuNavig.Play();
    }
}
