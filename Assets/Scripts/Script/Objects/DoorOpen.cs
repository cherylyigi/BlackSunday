using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class DoorOpen : MonoBehaviour {

    public Transform ChatBackGround;
    public Transform Player;

    public UpdateCanvas canvas;

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}

