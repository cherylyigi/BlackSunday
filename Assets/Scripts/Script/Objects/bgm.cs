using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;
using UnityEngine;
using Character.Player;
using UnityEngine.SceneManagement;

public class bgm : MyObject
{

    public AudioClip MusicClip;

    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }

    void Update()
    {
        if (MusicSource.time > 40f)
        {
            MusicSource.Stop();
            MusicSource.Play();
        }
    }

}
