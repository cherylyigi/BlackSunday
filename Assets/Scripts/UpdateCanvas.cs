using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCanvas : MonoBehaviour
{    
    public GameObject Canvas;

    public void CloseCanvas() {
        if (Canvas != null) {
            Canvas.SetActive(false);
        }
    }

    public void DisplayCanvas(string text) {
        if (Canvas != null) {
            Text message = Canvas.transform.GetChild(1).gameObject.GetComponent<Text>();
            message.text = text;
            Canvas.SetActive(true);
        }
    }  
}
