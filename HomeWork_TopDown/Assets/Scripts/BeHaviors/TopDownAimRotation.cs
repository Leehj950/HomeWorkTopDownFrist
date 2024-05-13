using System;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private Transform aimPivot;
    [SerializeField] private SpriteRenderer characterRenderer;


    private TopDownController controller;
    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 vector)
    {
        RotationAim(vector);
    }

    private void RotationAim(Vector2 vector)
    {
        Debug.Log("체크");
        // 회전공식
        float rotz = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotz) > 90f;

        aimPivot.rotation = Quaternion.Euler(0, 0, rotz);
    }
}