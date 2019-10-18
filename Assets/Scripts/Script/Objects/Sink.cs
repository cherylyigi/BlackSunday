using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;
using UnityEngine;
using Character.Player;
using UnityEngine.SceneManagement;

public class Sink : MyObject
{
    string name = "Sink";

    public AudioClip MusicClip;

    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;

    }

    // Update is called once per frame
    public override void react()
    {
        target.GetComponent<Player>().WashHand();
        canvas.DisplayCanvas("I feel so dizzy....... Ehh the icy water makes me feel better.");
        MusicSource.Play();
    }

    void Update()
    {
        if (MusicSource.time > 3f)
        {
            MusicSource.Stop();
        }
    }

}
