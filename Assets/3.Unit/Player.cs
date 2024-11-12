using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Unit
{
    
    public Animator SwordAni;
    public bool BossStageStart = false;
    
    public void Start()
    {
        ChangeType(new NormalAttack(this, Vector2.up, TargetLayer));
    }

    public void FixedUpdate()
    {
        if (!ReferenceEquals(MoveType, null))
            MoveType.Move();
        if (!ReferenceEquals(AttackType, null))
            AttackType.Attack();
        if (!ReferenceEquals(SkillType, null))
            SkillType.Skill();
    }

    public override bool AttackCondition()
    {
        return false;
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (BossStageStart && collision.transform.TryGetComponent(out BossMonster boss))
        {
            boss.GetUnitStates().CurrentHp -= UnitStates.AttackPower;
        }
    }

    public override void Die()
    {
        if (UnitStates.CurrentHp <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}


