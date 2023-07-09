using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    Vector2 movement;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
    //    if (aiPath.desiredVelocity.x <= 0.01f) {
    //        transform.localScale = new Vector3(-1f, 1f, 1f);
    //    } else if (aiPath.desiredVelocity.x >= -0.01f) {
    //        transform.localScale = new Vector3(1f, 1f, 1f);
    //    }


        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
