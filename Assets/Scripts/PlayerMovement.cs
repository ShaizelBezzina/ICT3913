using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jump = 14f;
    [SerializeField] private float speed = 2f;
    [SerializeField] private LayerMask jumpableGround;
    private float dirX = 0;

    private enum MovementState { idle, running, jumping, falling }

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    private BoxCollider2D coll;
    [SerializeField] private AudioSource jumpEffectSound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }


    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal"); //when we press left it wll be set to -1 and we press right ot will be set to +1

        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);

        UpdateAnimState();
    }



    private void UpdateAnimState()
    {
        MovementState State;

        if (dirX < 0f)
        {
            State = MovementState.running;
            sr.flipX = true;
        }
        else if (dirX > 0f)
        {
            State = MovementState.running;
            sr.flipX = false;
        }
        else
        {
            State = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            State = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            State = MovementState.falling;
        }
       
        anim.SetInteger("State", (int)State); //casting the enum into an integer which can be used in the animator
    }
    
    private bool IsGrounded() //this functions makes the player not jump when it is in the air
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}