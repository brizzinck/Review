using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    private Rigidbody2D _rigidbody;
    private Vector2 _directory;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        _directory.x = Input.GetAxisRaw("Horizontal");
        _rigidbody.velocity = new Vector2(_speed * _directory.x, _rigidbody.velocity.y);
    }
}