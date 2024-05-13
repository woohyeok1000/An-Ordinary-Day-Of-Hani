using UnityEngine;

public class Movement : MonoBehaviour
{    
    private MainController controller;
    private Rigidbody2D movementRigidbody;    

    private Vector2 movementDirection = Vector2.zero;

    private void Awake() // Awake 에서는 주로 내 컴포넌트 안에서 끝나는 것
    {
        // controller 랑 TopDownMovement 랑 같은 게임 오브젝트 안에 있다라는 가정
        controller = GetComponent<MainController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate() // FixedUpdate 는 물리업데이트와 관련이 있다
    {
        // rigidbody 의 값을 바꾸니까 물리 업데이트 발생
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5f;
        movementRigidbody.velocity = direction;
    }
}
