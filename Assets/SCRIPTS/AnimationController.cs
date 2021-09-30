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
    Data mana_and_hp;
    [SerializeField] private GameObject Data_Object;
    bool one_Dead = true;
    void Start()
    {
        mana_and_hp = Data_Object.GetComponent<Data>();
        animator = GetComponent<Animator>();
        p = GetComponent<PlayerJumpAndSit>();
    }
    void Update()
    {
         _direction = Input.GetAxisRaw("Horizontal");
        animator.SetFloat(_runAnimatorKey, Mathf.Abs(_direction));
        if (Input.GetMouseButtonDown(0) && !p.crouching && !Data.Death)
        {
            animator.SetTrigger("Attack");
        }  

        if (Data.Death && one_Dead)
        {
            
            animator.SetTrigger("Dead");
            one_Dead = false;
        }
    }
}
