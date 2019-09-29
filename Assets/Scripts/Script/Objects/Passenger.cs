using System.Collections;
using System.Collections.Generic;
using MyHuman;


public class Passenger : Human
{
    string Name = "???";
    string Dialogue = "AOEWY???";

    public override void react()
    {
        print(Dialogue);
    }

}
