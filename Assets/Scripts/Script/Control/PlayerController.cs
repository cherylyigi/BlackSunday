using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Objects.MyObject;

public class PlayerController : MonoBehaviour 
{
    float standspeed = 0f;
    float walkspeed = 1.558401f;
    float runspeed = 5.662317f;
    Vector3 standstill = new Vector3(0,0,0);
    float XAngle = 0;
    float YAngle = 0;
    float ZAngle = 0;
    bool isGrounded = true;
    void Update()
    {
        //MoveToCursor();
        KeyBoardMove();
        if (Input.GetMouseButton(0)) 
        {
            Interact();
        }
    }

    // control the player to move via keyboard.
    private void KeyBoardMove()
    {
        Vector3 localvelocity = standstill;
        YAngle = 0;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey("w"))
            {
                localvelocity.z = runspeed;
            } 
            else if (Input.GetKey("s"))
            {
                localvelocity.z = -1 * runspeed;
            }
            if (Input.GetKey("a"))
            {
                YAngle -= 3;
            }
            else if (Input.GetKey("d"))
            {
                YAngle += 3;
            } 
            /*if (Input.GetKeyDown(KeyCode.Space)) {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 40, ForceMode.Impulse);
                print("?????");
            }*/
        }
        else
        {
            if (Input.GetKey("w"))
            {
                localvelocity.z = walkspeed;
            }
            else if (Input.GetKey("s"))
            {
                localvelocity.z = -1 * walkspeed;
            }
            if (Input.GetKey("a"))
            {
                YAngle -= 3;
            }
            else if (Input.GetKey("d"))
            {
                YAngle += 3;
            }
            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 40, ForceMode.Impulse);
            }*/
        }
        transform.Rotate(XAngle, YAngle, ZAngle, Space.Self);
        GetComponent<NavMeshAgent>().velocity = transform.TransformVector(localvelocity);
    }
 
    /*private void Jump(bool super = false) {
        Vector3 jump = new Vector3(0.0f, 20.0f, 0.0f);
        float jumpForce = 200.0f;

        Rigidbody rb = GetComponent<Rigidbody>();

        if (isGrounded)
        {   
            if (super) { jumpForce = 400.0f; }
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            print(super);
            isGrounded = false;
        }
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }*/

    private Ray GetMouseRay() 
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    private void Interact() 
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        MyObject Yeah;
        if (hasHit)
        {
            if (Yeah = hit.transform.GetComponent<MyObject>()) {
                Yeah.react();
            }
        }
    }
    
}