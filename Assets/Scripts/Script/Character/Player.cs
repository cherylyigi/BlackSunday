using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Objects.MyObject;

namespace Character.Player
{
    public class Player : MonoBehaviour 
    {
        bool isWash = false;
        bool isDry = false;

        public bool IsWash() { return isWash; }
        public bool IsDry() { return isDry; }

        public void WashHand() {isWash=true; }
        public void DryHand() {isWash=true; }
    }
}