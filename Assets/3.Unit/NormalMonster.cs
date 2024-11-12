using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NormalMonsterType
{
    NormalSlime,
    BoomSlime,
    ShotFireMonster,
    ShotLightningMonster
}
[Serializable]
public class NormalMonster : Unit
{
    public NormalMonsterType Type;

    public void Start()
    {
        SelectType();
    }

    public void FixedUpdate()
    {
        AttackType.Attack();
    }

    public void SelectType()
    {
        switch (Type)
        {
            case NormalMonsterType.NormalSlime:
                ChangeType(new NormalAttack(this, Vector2.down, TargetLayer));
                break;
        }
    }

    public override bool AttackCondition()
    {
        return true;
    }
}
