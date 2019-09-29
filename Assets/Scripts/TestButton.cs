using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public GameObject Canvas;
    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            DisplayCanvas("asd");
        }
    }

    public void DisplayCanvas(string text) {
        if (Canvas != null) {
            Canvas.GetComponent<UpdateCanvas>().DisplayCanvas(text);
        }
    }
}
