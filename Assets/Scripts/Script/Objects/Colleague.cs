using System.Collections;
using System.Collections.Generic;
using MyHuman;


public class Colleague : Human
{
    string Name = "???";
    string Dialogue = "What What What???";
    public UpdateCanvas canvas;

    public override void react()
    {
        canvas.DisplayCanvas(Dialogue);
    }

}

