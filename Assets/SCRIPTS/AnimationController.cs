using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private float _direction;

    [SerializeField] private string _runAnimatorKey;
    [Header(("Animation"))]
    [SerializeField] Animator animator;
    PlayerJumpAndSit p;
    void Start()
    {
        animator = GetComponent<Animator>();
        p = GetComponent<PlayerJumpAndSit>();
    }


    void Update()
    {
        _direction = Input.GetAxisRaw("Horizontal");
        animator.SetFloat(_runAnimatorKey, Mathf.Abs(_direction));
        if (Input.GetMouseButtonDown(0) && !p.crouching)
        {
            animator.SetTrigger("Attack");
        }
    }
}
