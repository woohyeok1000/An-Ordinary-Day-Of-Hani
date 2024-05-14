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
        // 어떤 캐릭터를 선택했는지 확인 후 해당되지 않은 캐릭터 비활성화
        //if(HaniButton.GetComponent<HaniButton>().isHani == true) // 오류로 인해 주석처리..
        //{
        //    Player_2.SetActive(false);
        //}
    }
}
