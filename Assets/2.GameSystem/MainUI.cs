using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    //버튼 변수
    public Button StartBtn;
    public Button ExplainBtn;
    public Button ExitBtn;

    //패널변수
    public GameObject ExplainPanel;

    public void Awake()//게임 시작시 제일 먼저 실행
    {
        StartBtn.onClick.AddListener(() => { SceneManager.LoadScene(1); });   //클릭시 게임씬 이동
        ExplainBtn.onClick.AddListener(() => { ExplainPanel.gameObject.SetActive(true); });//클릭시 설명 창 출력
        ExitBtn.onClick.AddListener(() => { Application.Quit(); ; });//클릭시 게임종료
    }
}
