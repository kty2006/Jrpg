using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//빌더 패턴 사용
public struct TurnBasedData
{
    public Unit unit;

    public TurnBasedData(Unit unit)
    {
        this.unit = unit;
    }
}
