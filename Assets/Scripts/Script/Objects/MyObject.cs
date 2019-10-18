using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Objects.MyObject {

    public class MyObject : MonoBehaviour
    {
        [SerializeField] public Transform target;
        [SerializeField] public Textbox text;

        public UpdateCanvas canvas;
        [TextArea(5, 10)]
        public string[] sentences;

        public virtual void react() {

        }
    }
}
