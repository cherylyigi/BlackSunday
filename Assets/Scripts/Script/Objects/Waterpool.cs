using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Objects.MyObject;

public class Waterpool : MyObject
{
    //string name = "Waterpool";
    int tolerance = 30;

    void Update() {
        react();
    }

    public override void react()
    {
        if (stepOn())
        {
            if(tolerance > 0) { tolerance--; }
            else 
            {
                Debug.Log("You die");
            }
        }
    }

    private bool stepOn()
    {
        float PlayerX = target.transform.position.x;
        float PlayerZ = target.transform.position.z;
        float MyX = transform.position.x;
        float MyZ = transform.position.z;
        float Xdiff_squa = (PlayerX - MyX) * (PlayerX - MyX);
        float Zdiff_squa = (PlayerZ - MyZ) * (PlayerZ - MyZ);
        double MyLength_squa = GetComponent<MeshRenderer>().bounds.size.x / 1.4;
        MyLength_squa *= MyLength_squa;
        bool step = (Xdiff_squa + Zdiff_squa < MyLength_squa);
        //Debug.Log(Xdiff_squa + " " + Zdiff_squa + " " + MyLength_squa);
        return step;
    }

}