using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparent : MonoBehaviour
{
    void Start(){
        gameObject.GetComponent<Renderer>().material.color= 
               new Color(1.0f,1.0f, 1.0f,1.0f);
    }
}