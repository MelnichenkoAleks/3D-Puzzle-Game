using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    public Animator animator; 

    private void Start()
    {
        animator.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube")) 
        {
            animator.enabled = true; 
            animator.Play("CylinderUp"); 
        }
    }
}