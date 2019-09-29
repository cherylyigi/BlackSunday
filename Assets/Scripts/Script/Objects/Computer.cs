using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Objects.MyObject;


public class Computer : MyObject
{
    string name = "Computer";
    string state = "Flushing";
    string brightness = "light on";
    int FlushCount = 3;
    int FlushTimer = 10;
    [SerializeField] Transform Plug;

    // Update is called once per frame
    void Update()
    {
        if (state == "Flushing")
        {
            if (FlushTimer > 0) { FlushTimer -- ; } 
            else if (brightness == "light on") { lightDown(); }
            else { lightUp(); }
        }
        if (Plug.GetComponent<Plug>().getState() == "off") {
            turnOff();
        }
    }


    public override void react()
    {
        if (state == "Flushing") {
            if (FlushCount == 3) {
                print("Flushing screen. Hmmm... That's Weird, there must be something wrong with it. I need to fix it before I leave.");
                FlushCount --;
            } else if (FlushCount == 2) {
                print("It doesn't seems like hardware issue. Ehh my head feels like exploding... ");
                FlushCount --;
            } else if (FlushCount == 1) {
                print("Why should I do this shit after work at Friday?? It sucks...");
                FlushCount --;
                turnOn();
            }
        }
        else if (state == "On") {
            print ("A Skype conversation with collegue");
            print ("I tried to turn off the computer, but nothing happens. I don't want to waste anytime on this shit, this is my Friday.");
            print ("Figure a way to turn it off, whatever method, and let's go home.");
        }
        else {
            print ("Thanks god it works. I should go home now. The headache becomes intense, I can barely think.");
        }
    }

    private void lightUp() {
        Material[] mats = transform.GetComponent<Renderer>().materials;
        Material BrightMaterial = Resources.Load("Interface_mtl", typeof(Material)) as Material;
        mats[1] = BrightMaterial;
        brightness = "light up";
    }

    private void lightDown() {
        Material[] mats = transform.GetComponent<Renderer>().materials;
        Material DarkMaterial = Resources.Load("Interface_bc", typeof(Material)) as Material;
        mats[1] = DarkMaterial;
        brightness = "light down";
    }

    private void turnOn() {
        lightUp();
        state = "On";
    }

    private void turnOff() {
        lightDown();
        state = "Off";
    }
}
