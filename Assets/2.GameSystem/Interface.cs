using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{
    public Unit Unit { get; set; }
    public void Move();
}

public interface IAttack
{
    public Unit Unit { get; set; }
    public void Attack();
}

public interface ISkill
{
    public Unit Unit { get; set; }
    public void Skill();
}

public interface ICommand
{
    public void Excute();
}
