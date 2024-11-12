using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Button playerTurn;

    public Button monsterTurn;

    public Button turnStart;

    public void Start()
    {
        Debug.Log(NormalMonster.Instance);
        playerTurn.onClick.AddListener(() => { TurnBased.TurnAdd(new TurnBasedData(Player.Instance)); });
        monsterTurn.onClick.AddListener(() => { TurnBased.TurnAdd(new TurnBasedData(NormalMonster.Instance)); });
        turnStart.onClick.AddListener(() => { TurnBased.TurnStart(); });
    }
}
