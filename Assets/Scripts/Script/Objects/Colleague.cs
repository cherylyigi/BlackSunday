using System.Collections;
using System.Collections.Generic;
using Character.Player;
using Objects.MyObject;
using UnityEngine;
using UnityEngine.AI;


public class Colleague : MyObject
{
    string Name = "???";

    string Dialogue1 = "Colleague: Hey Steven, there you are. Why do you look so tired? Anyway, boss said that you must finish this Jira ticket by this weekend, it's an urgent demand from the major client...";
    string Dialogue2 = "Me: Wait wait, an extra Jira coming at Friday 7pm?? are you serious?";
    string Dialogue3 = "Collegue: Nah... Actually boss told me this morning, but I... Nevermind, you won't mind a little bit overtime, will you?";
    string Dialogue4 = "Me: ...";
    string Dialogue5 = "Colleague: OK I've passed the word. I have a party at the Downtown Bar, gotta go! Oh BTW, remember to turn off all the computers before you leave. It's very seriously listed in the employye handbook. Good luck in your work my friend!";


    public override void react()
    {
        int num_sentences = 5;
            while (num_sentences > 0)
        {
            if (Input.GetKeyDown("x")) {
                canvas.DisplayCanvas("Go away! I'm not gonna do this shit at Friday night!");
                leave();
                break;
            } else if (Input.GetKeyDown("z")) {
                switch(num_sentences) {
                    case 5:
                        canvas.DisplayCanvas(Dialogue1);
                        num_sentences--;
                        break;
                    case 4:
                        canvas.DisplayCanvas(Dialogue2);
                        num_sentences--;
                        break;
                    case 3:
                        canvas.DisplayCanvas(Dialogue3);
                        num_sentences--;
                        break;
                    case 2:
                        canvas.DisplayCanvas(Dialogue4);
                        num_sentences--;
                        break;
                    case 1:
                        canvas.DisplayCanvas(Dialogue5);
                        num_sentences--;
                        break;
                    default: 
                        leave();
                        break;
                }
            }
        }
    }

    private static void leave()
    { }

}

