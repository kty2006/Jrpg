using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBased : MonoBehaviour
{
    public TurnBasedCommand TurnBasedCommand = new();
    public static Action<TurnBasedData> TurnAdd;
    public static Action TurnStart;

    public void Awake()
    {
        TurnAdd = (data) => { ActionAdd(data); };
        TurnStart = () => { ActionsStart(); };
    }

    public void ActionAdd(TurnBasedData data)
    {
        TurnBasedCommand.Actions.Enqueue(data);
        Debug.Log("�Ҵ�");
    }

    public void ActionsStart()
    {
        TurnBasedCommand.Excute();
        Debug.Log("����");
    }


}
