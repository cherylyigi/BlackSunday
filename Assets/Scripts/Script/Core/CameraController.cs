using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float XAngle = 0;
    float YAngle = 0;
    float MaxXAngle = 60F;
    float MinXAngle = -60F;
    float normalSpeed = 5F;
    float superSpeed = 10F;
    float yspeed;
    float xspeed;

    // Update is called once per frame
    void Update()
    {
        KeyBoardRotate();
    }

    private void KeyBoardRotate()
    {
        float xspeed = 0;
        float yspeed = 0;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.UpArrow)) 
            {
                xspeed = -1 * superSpeed;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                yspeed = superSpeed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                xspeed =  superSpeed;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                yspeed = -1 * superSpeed;
            }

        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                xspeed = -1 * normalSpeed;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                yspeed = normalSpeed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                xspeed = normalSpeed;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                yspeed = -1 * normalSpeed;
            }

        }
        if (XAngle + xspeed < MaxXAngle && XAngle + xspeed > MinXAngle) 
        {
            Vector3 rotation = new Vector3(xspeed, yspeed, 0);
            transform.eulerAngles = transform.eulerAngles + rotation;
        }
    }
}
