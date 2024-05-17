using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAnimations : MonoBehaviour
{
    private readonly int moveX = Animator.StringToHash("MoveX");
    private readonly int moveY = Animator.StringToHash("MoveY");
    private readonly int isMoving = Animator.StringToHash("IsMoving");
    private readonly int isDeath = Animator.StringToHash("Death");

    private Animator animator;

    private void Awake()
    {
        //Luôn phải lấy giá trị trước thì game mới chạy
        animator = GetComponent<Animator>();
    }

    public void SetDeathAnimation()
    {
        animator.SetTrigger(isDeath);
    }

    public void SetMovingAnimation(bool value)
    {
        animator.SetBool(isMoving, value);
    }

    public void SetMoveBoolTransition(Vector2 dir) 
    {
        animator.SetFloat(moveX, dir.x);
        animator.SetFloat(moveY, dir.y);
    }
}
