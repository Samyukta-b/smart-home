using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get the Animator component attached to the door GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the "O" key is pressed
        if (Input.GetKeyDown(KeyCode.O))
        {
            // Trigger the DoorOpen animation
            animator.Play("DoorOpen");
        }

        // Check if the "C" key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Trigger the DoorClose animation
            animator.Play("DoorClose");
        }
    }
}
