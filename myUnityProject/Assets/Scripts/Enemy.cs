using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;
    private float attackDelay = 3;
    private bool isAttacking = false;
    private bool isRunning = false;
    public HealthBar healthBar;
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        if (isAttacking)
        {
            attackDelay -= Time.deltaTime;
            if (attackDelay <= 0)
            {
                isAttacking = false;
                attackDelay = 3;
            }
        }
    }
    void PlayAttack()
    {
        isRunning = false;
        animator.SetTrigger("Attack");
    }

    public void PlayIdle()
    {
        isRunning = false;
        animator.SetTrigger("Idle");
    }

     public void PlayRun()
    {
        if (!isRunning)
        {
            isRunning = true;
            animator.SetTrigger("Run");
        }
    }

    public void Attack()
    {
        if (!isAttacking)
        {
            isAttacking = true;
            PlayAttack();
            healthBar.TakeDamage();
        }
    }
    /* private void OnTriggerStay(Collider other)
    {
        Debug.Log("Something Entered " + other.tag);
        if (other.tag.Equals("Player") && !isAttacking)
        {
            isAttacking = true;
            Attack();
        }
    }
    */
}
