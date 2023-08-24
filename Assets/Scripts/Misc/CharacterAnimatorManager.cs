using UnityEngine;

public class CharacterAnimatorManager : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
            Debug.LogWarning("There is no Animator Component attached to this gameobject!");
    }

    public void Walk(bool doesWalk=true)
    {
        animator.SetBool("Walk", doesWalk);
    }
    public void Wave()
    {
        animator.SetTrigger("Wave");
    }
}
