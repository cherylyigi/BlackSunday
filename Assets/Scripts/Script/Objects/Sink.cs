using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;

public class Sink : MyObject
{
    string name = "Sink";
    public UpdateCanvas canvas;

    // Update is called once per frame
    public override void react()
    {
        canvas.DisplayCanvas("I feel so dizzy....... Ehh the icy water makes me feel better.");
    }
}
