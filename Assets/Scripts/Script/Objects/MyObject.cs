using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Objects.MyObject {

    public class MyObject : MonoBehaviour
    {
        [SerializeField] public Transform target;
        [SerializeField] public Textbox text;

        public virtual void react() {
            print("This is an Object");
        }
    }
}
