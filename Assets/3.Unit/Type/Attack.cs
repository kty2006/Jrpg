using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack : IAttack
{
    public Unit Unit { get; set; }
    private float attackCool;
    private Vector2 dir;
    private RaycastHit2D hit;
    private LayerMask layerMask;

    public NormalAttack(Unit unit, Vector2 dir, LayerMask layerMask)
    {
        Unit = unit;
        this.dir = dir;
        this.layerMask = layerMask;
    }

    public void Attack()
    {
        if (Unit.AttackCondition() && attackCool >= Unit.GetUnitStates().AttackSpeed)
        {
            hit = Physics2D.Raycast(Unit.transform.position, dir, Unit.GetUnitStates().AttackRange, layerMask);
            if (!ReferenceEquals(hit.transform, null))
            {
                Debug.Log(hit.transform);
                if (hit.collider.TryGetComponent(out Unit targetUnit))
                {
                    targetUnit.GetUnitStates().CurrentHp -= Unit.GetUnitStates().AttackPower;
                }
            }
            attackCool = 0;
        }
        attackCool += Time.deltaTime;
    }
}

