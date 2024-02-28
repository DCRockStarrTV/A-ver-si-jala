using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 Movimiento;
    [SerializeField] private float Speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = Movimiento * Speed;
    }

    private void OnMove(InputValue inputValue)
    {
        Movimiento = inputValue.Get<Vector2>();
    }
}
