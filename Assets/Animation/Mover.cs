using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
	[SerializeField] Transform t;

    private void Start()
    {
        GetComponent<NavMeshAgent>().destination = t.position;
    }
    // Update is called once per frame
    void Update()
	{
        Vector3 currPos = this.transform.position;
        if (Vector3.Distance(currPos, t.position) < 0.5f)
        {
            GetComponent<Animator>().SetFloat("Blend", 1.0f);
        }
    }
}