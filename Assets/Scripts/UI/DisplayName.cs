using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    // 캐릭터를 따라가는 이름표 (카메라 추적 응용)
    public Text playerNameText;
    public Transform player;
    [SerializeField] float smooth = 0.2f;
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;    
    }

    private void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, 0);
        transform.position = Vector3.Lerp(transform.position, targetPos, smooth);
    }
}
