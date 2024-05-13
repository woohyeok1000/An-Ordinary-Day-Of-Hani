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

    public enum Character
    {
        Player,
        Player_2
    }

    public void Awake()
    {
        //if(HaniButton.gameObject.) Player.SetActive(false);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
