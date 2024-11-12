using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    //��ư ����
    public Button StartBtn;
    public Button ExplainBtn;
    public Button ExitBtn;

    //�гκ���
    public GameObject ExplainPanel;

    public void Awake()//���� ���۽� ���� ���� ����
    {
        StartBtn.onClick.AddListener(() => { SceneManager.LoadScene(1); });   //Ŭ���� ���Ӿ� �̵�
        ExplainBtn.onClick.AddListener(() => { ExplainPanel.gameObject.SetActive(true); });//Ŭ���� ���� â ���
        ExitBtn.onClick.AddListener(() => { Application.Quit(); ; });//Ŭ���� ��������
    }
}
