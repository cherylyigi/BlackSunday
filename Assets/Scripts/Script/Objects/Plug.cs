using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;
using UnityEngine;
using UnityEngine.AI;
using Character.Player;


public class Plug : MyObject
{
    [SerializeField] Transform player;

    string state = "On";
    string name = "Plug";
    
    public override void react()
    {
        // if (player.GetComponent<Player>().getHand()) {
        //     print("you die");
        //     return;
        // }
        // print("OK, now it should work. Let's go and check.");
    }

    public string getState() { return state; }
}