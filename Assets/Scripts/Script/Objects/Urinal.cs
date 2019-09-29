using System.Collections;
using System.Collections.Generic;
using Objects.MyObject;

public class Urinal : MyObject
{
    string name = "Urinal";

    // Update is called once per frame
    public void react()
    {
        print("It is dirty. Somebody didn't flush it.");
    }
}
