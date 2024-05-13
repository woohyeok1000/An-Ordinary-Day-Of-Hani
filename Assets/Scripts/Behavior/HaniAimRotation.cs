using System;
using UnityEngine;

public class HaniAimRotation : MonoBehaviour
{    
    [SerializeField] private Transform bodyPivot;

    [SerializeField] private SpriteRenderer HaniRenderer;

    private MainController controller;

    private void Awake()
    {
        controller = GetComponent<MainController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        HaniRenderer.flipX = Mathf.Abs(rotZ) > 90f;

        bodyPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
