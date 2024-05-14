using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    // 글자 수 제한이 있는 이름 입력, 제한사항을 넘을 때 버튼 비활성화

    public InputField playerNameInput;
    public string playerName;
    public StartButton getButton;
    public void GameStart()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;

        if (playerName.Length > 2 && playerName.Length < 10)
        {            
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");            
        }
        else
        {
            getButton.enabled = false;
        }
    }
}
