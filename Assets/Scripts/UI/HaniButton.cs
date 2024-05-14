using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaniButton : MonoBehaviour
{
    // 캐릭터 선택 버튼마다 검증용 함수를 넣고 추후에 게임매니저에서 사용
    public bool isHani = false;

    public void ChooseHani()
    {
        isHani = true;
    }
}
