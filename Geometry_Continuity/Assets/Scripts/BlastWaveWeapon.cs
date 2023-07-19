using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastWaveWeapon : MonoBehaviour
{
    [SerializeField] float timeToAttack = 4f;
    float timer;

    [SerializeField] GameObject leftBlastObject;
    [SerializeField] GameObject rightBlastObject;
    [SerializeField] Vector2 blastAttackSize = new Vector2(4f, 2f);
    [SerializeField] int blastDamage;

    PlayerMove playerMove;

    Animator blastAnimation;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
        blastAnimation = GetComponent<Animator>();
    }


    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();

        }
        
    }

    private void Attack()
    {

        timer = timeToAttack;

        if (playerMove.lastHorizontalVector > 0)
        {
            rightBlastObject.SetActive(true);
            Collider2D[] colliders =  Physics2D.OverlapBoxAll(rightBlastObject.transform.position, blastAttackSize, 0f);
            ApplyDamage(colliders);
        }
        else
        {
            leftBlastObject.SetActive(true);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(leftBlastObject.transform.position, blastAttackSize, 0f);
            ApplyDamage(colliders);
        }
    }

    private void ApplyDamage(Collider2D[] colliders)
    {
        for (int i = 0; i < colliders.Length; i++)
        {
            IDamagable e = colliders[i].GetComponent<IDamagable>();
            if (e != null)
            {
                e.TakeDamage(blastDamage);
            }
            
        }
        
    }
}
