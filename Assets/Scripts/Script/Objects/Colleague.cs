using System.Collections;
using System.Collections.Generic;
using MyHuman;


public class Colleague : Human
{
    string Name = "???";
    string Dialogue = "What What What???";

    public override void react()
    {
        print(Dialogue);
    }

}

