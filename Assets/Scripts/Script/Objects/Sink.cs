using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;

public class Sink : MyObject
{
    string name = "Sink";

    // Update is called once per frame
    public override void react()
    {
        print("I feel so dizzy....... Ehh the icy water makes me feel better.");
    }
}
