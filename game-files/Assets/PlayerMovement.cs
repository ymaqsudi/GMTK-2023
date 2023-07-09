using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    public GameObject crossHair; 
    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        MoveCrossHair();
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }


    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    private void MoveCrossHair(){
        Vector2 aim = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = aim - rb.position;
        
        if (aim.magnitude > 0.0f){
            lookDir.Normalize();
            crossHair.transform.localPosition = lookDir/2;
        }
    }
}
