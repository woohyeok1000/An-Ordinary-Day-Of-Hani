using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
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
