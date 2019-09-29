using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Objects.MyObject;

namespace Character.Player
{
    public class Player : MonoBehaviour 
    {
        string name = "Yigi";
        bool wetHand = true;

        public bool getHand() { return wetHand; }
    }
}