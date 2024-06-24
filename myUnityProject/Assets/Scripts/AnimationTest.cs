using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // move the cube left and right
            Debug.Log("E pressed");
            animator.SetTrigger("Side");
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            // move the cube up and down
            Debug.Log("U pressed");
            animator.SetTrigger("Up");
        }
    }
}
