using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Config")] 
    [SerializeField] private float playerSpeed;

    private PlayerAnimations animations;
    private PlayerActions actions;
    private Rigidbody2D rg2d;
    private Vector2 moveDirection;


    private void Awake()
    {
        //Luôn phải lấy giá trị trước thì game mới chạy
        actions = new PlayerActions();
        rg2d = GetComponent<Rigidbody2D>();
        animations = GetComponent<PlayerAnimations>();
    }

    // Update is called once per frame
    void Update()
    {
        //Update direction liên tục
        ReadMovement();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        //Time.fixedDeltaTime - bảo Unity ko quan tâm tới framerate (fixedDeltaTime = fixed framerate)
        rg2d.MovePosition(rg2d.position + moveDirection * (playerSpeed * Time.fixedDeltaTime)); 
    }

    private void ReadMovement()
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
        //Update giá trị của MoveX, MoveY - để set animation
        //Đồng thời kiểm tra biến IsMoving
        if (moveDirection ==  Vector2.zero)
        {
            animations.SetMovingAnimation(false);
            return;
        }
        animations.SetMovingAnimation(true);
        animations.SetMoveBoolTransition(moveDirection);

    }

    private void OnEnable()
    {
        actions.Enable();
    }

    private void OnDisable()
    {
        actions.Disable();
    }
}
