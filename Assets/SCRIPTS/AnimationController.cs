using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnimationController : MonoBehaviour
{
    private float _direction;
    private float _damageDelay=0.6f;
    private float _lastDamageTime;
    private float _damageDelayforFireboll = 0.6f;
    private float _lastDamageTimeforFireboll;
    [SerializeField] private string _runAnimatorKey;
    [Header(("Animation"))]
    [SerializeField] Animator animator;
    PlayerJumpAndSit p;
    bool one_Dead = true;
    public static bool CanTackeSwordDamage = false;
    [SerializeField] private GameObject FireBoll;
    [SerializeField] private Transform PosForFireboll;

    Data data;
    public GameObject data_script;
    void Start()
    {
        animator = GetComponent<Animator>();
        p = GetComponent<PlayerJumpAndSit>();
        data = data_script.GetComponent<Data>();
    }
    void Update()
    {
        print(CanTackeSwordDamage);
         _direction = Input.GetAxisRaw("Horizontal");
        animator.SetFloat(_runAnimatorKey, Mathf.Abs(_direction));
        if (Input.GetMouseButtonDown(0) && p.isGrounded && !p.crouching && !Data.Death  && !Skills.lightCheck && Time.time - _lastDamageTime > _damageDelay)
        {
            _lastDamageTime = Time.time;
            CanTackeSwordDamage = true;
            animator.SetTrigger("Attack");
            Invoke("Attack", 0.5f);
        }
        else if (data.ManaImagen.fillAmount > 0 && Input.GetMouseButtonDown(1) && Time.time - _lastDamageTimeforFireboll > _damageDelayforFireboll)
        {
            
            _lastDamageTimeforFireboll = Time.time;
            Invoke("Fireboll", 0.5f);
        }
        if (Data.Death && one_Dead)
        {
            
            animator.SetTrigger("Dead");
            one_Dead = false;
        }
    }
    void Attack()
    {
        CanTackeSwordDamage = false;
       
    }
    void Fireboll()
    {
        data.ManaImagen.fillAmount -= 0.1f;
        Data.Mana -= 10;
        Instantiate(FireBoll, PosForFireboll.position, PosForFireboll.rotation);
    }
}
