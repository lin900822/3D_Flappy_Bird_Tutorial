using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody birdRigidbody;

    [SerializeField] private Animator birdAnimator;

    [SerializeField] private float jumpForce;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidbody.velocity = Vector3.up * jumpForce;
        }

        if(birdRigidbody.velocity.y > 0)
        {
            birdAnimator.SetBool("isFly", true);
            birdAnimator.SetBool("isFall", false);
        }
        else
        {
            birdAnimator.SetBool("isFly", false);
            birdAnimator.SetBool("isFall", true);
        }
    }
}
