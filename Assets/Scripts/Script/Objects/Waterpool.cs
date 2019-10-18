using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Objects.MyObject;
using UnityEngine.SceneManagement;

public class Waterpool : MyObject
{
    //string name = "Waterpool";
    int tolerance = 30;
    private bool showBefore = false;

    void Update() {
        react();
    }

    public override void react()
    {
        if (stepOn() && !showBefore)
        {
            if(tolerance > 0) { tolerance--; }
            else 
            {
                showBefore = true;
                //canvas.DisplayCanvas("It says wet floor, why did I waste my life?");
                SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings-1);
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