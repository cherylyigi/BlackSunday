using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class NPC : MonoBehaviour {

    public Transform ChatBackGround;
    public Transform Player;

    public UpdateCanvas canvas;
    private bool isOpen = false;

    [TextArea(5, 10)]
    public string[] sentences;

    public void OnTriggerEnter(Collider other)
    {
        if (!isOpen)
        {
            canvas.DisplayCanvas(sentences[0]);
            isOpen = true;
        }
    }

    public void OnTriggerExit()
    {
    }
}

