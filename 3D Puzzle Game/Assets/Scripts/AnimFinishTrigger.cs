using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimFinishTrigger : MonoBehaviour
{
    public Animator animator; 

    private void Start()
    {
        animator.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.enabled = true;
            animator.Play("WallFinish");
        }
    }
}