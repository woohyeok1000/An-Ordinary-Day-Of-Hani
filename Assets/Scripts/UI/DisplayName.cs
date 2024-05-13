using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text playerNameText;
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;    
    }

}
