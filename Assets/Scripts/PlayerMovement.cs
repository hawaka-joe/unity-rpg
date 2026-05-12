using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int facingDirection = 1;
    public Rigidbody2D rb;

    public Animator animator;

    // Update is called once per frame
    private Vector2 movementInput;

    void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        if (movementInput.x > 0 && transform.localScale.x < 0 || movementInput.x < 0 && transform.localScale.x > 0)
        {
            FlipPlayer();
        }
        animator.SetFloat("horizontal", Mathf.Abs(movementInput.x));
        animator.SetFloat("vertical", Mathf.Abs(movementInput.y));
        rb.linearVelocity = movementInput * moveSpeed;
    }

    void FlipPlayer()
    {
        facingDirection = -facingDirection;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
