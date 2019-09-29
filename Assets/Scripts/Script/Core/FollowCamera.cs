using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform Target;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("s")) { return; }
        transform.position = Target.position;
    }
}
