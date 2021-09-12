using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{

    public AudioSource track1, track2, track3;
    int random,playing;
    public static music musicInstance;

    // Start is called before the first frame update
    private void Awake()
    {
        if(musicInstance!=null && musicInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        musicInstance = this;
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        random = Random.Range(0, 2);
        if (random == 0)
        {
            track1.Play();
            playing = 1;
        }
        if (random == 1)
        {
            track3.Play();
            playing = 3;
        }
        if (random == 2)
        {
            track2.Play();
            playing = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!track1.isPlaying && playing==1)
        {
            track2.Play();
            playing = 2;
        }
        if(!track2.isPlaying && playing==2)
        {
            track3.Play();
            playing = 3;
        }
        if(!track3.isPlaying && playing == 3)
        {
            track1.Play();
            playing = 1;
        }
    }
}
