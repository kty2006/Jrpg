using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class States
{
    public float MaxHp;
    public float CurrentHp;
    public float AttackPower;
    public float AttackSpeed;
    public float AttackRange;
    public float CriticalDamage;
    public float CriticalChance;
    public float Movespeed;
}

public class Unit : MonoBehaviour
{
    public States UnitStates;
    public static Unit Instance;

    public void Awake()
    {
        Instance = this;
        Debug.Log(Instance);
    }

    public States GetUnitStates()//null값 방지를 위한 함수 사용
    {
        return UnitStates;
    }

    public Vector2Int currentIndex;

    public LayerMask TargetLayer;

    public bool HitCheck = false;

    protected IMove MoveType;
    protected IAttack AttackType;
    protected ISkill SkillType;

    public virtual void Update()
    {
        //Die();
    }

    public void ChangeType(IMove moveType)
    { MoveType = moveType; }

    public void ChangeType(IAttack attackType)
    { AttackType = attackType; }

    public void ChangeType(ISkill skillType)
    { SkillType = skillType; }

    public virtual bool AttackCondition()
    { return true; }

    public virtual void Die()
    {
        if (UnitStates.CurrentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
