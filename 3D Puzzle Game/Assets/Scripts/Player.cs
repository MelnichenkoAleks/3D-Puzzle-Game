using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }

    
    }


    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            Activator[] buttons = FindObjectsOfType<Activator>();
            foreach (Activator button in buttons)
            {
                button.canPush = false;
            }
        }
    
    }

    private void OnTriggerExit(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            Activator[] buttons = FindObjectsOfType<Activator>();
            foreach (Activator button in buttons)
            {
                button.canPush = true;
            }
        }
    }








}