using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance()
    {
        if (instance == null)
        {
            instance = new GameManager();
        }
        return instance;
    }

    public GameObject HaniButton;
    public GameObject ChickenButton;
    public GameObject Player;
    public GameObject Player_2;
    

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        // � ĳ���͸� �����ߴ��� Ȯ�� �� �ش���� ���� ĳ���� ��Ȱ��ȭ
        //if(HaniButton.GetComponent<HaniButton>().isHani == true) // ������ ���� �ּ�ó��..
        //{
        //    Player_2.SetActive(false);
        //}
    }
}
