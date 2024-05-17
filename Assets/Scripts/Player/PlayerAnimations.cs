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

    /// <summary>
    /// Để trigger animation Dead
    /// </summary>
    public void SetDeathAnimation()
    {
        animator.SetTrigger(isDeath);
    }

    /// <summary>
    /// Check isMoving có đang di chuyển hay ko
    /// </summary>
    /// <param name="value"></param>
    public void SetMoveBoolTransition(bool value)
    {
        animator.SetBool(isMoving, value);
    }

    /// <summary>
    /// Update lại giá trị để player di chuyển
    /// </summary>
    /// <param name="dir"></param>
    public void SetMoveAnimation(Vector2 dir) 
    {
        animator.SetFloat(moveX, dir.x);
        animator.SetFloat(moveY, dir.y);
    }
}
