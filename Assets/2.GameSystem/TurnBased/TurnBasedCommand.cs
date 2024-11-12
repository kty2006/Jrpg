using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCommand : ICommand
{
    //public Queue<TurnBasedData> turnBasedData;
    public Queue<TurnBasedData> Actions = new();
    public void Excute()
    {
        foreach (var Action in Actions)
        {
            Debug.Log(Action.unit);
        }
    }
}
