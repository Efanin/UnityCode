using UnityEngine;

public class AnimPlayer : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PlayJump()
    {
        if(!animator.GetCurrentAnimatorStateInfo(0).IsName("jumpanim"))
            animator.Play("base.jumpanim");
    }
}
