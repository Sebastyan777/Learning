using UnityEngine;

public class MoveTim : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _timRB;
    private Animator _animator;
    private Vector2 _moveVector;

    private void Awake()
    {
        _timRB = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _moveVector.x = Input.GetAxis("Horizontal");

        _timRB.MovePosition(_timRB.position + _moveVector * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            _animator.Play("MoveRight");
        else if (Input.GetKey(KeyCode.A))
            _animator.Play("MoveLeft");
        else
            _animator.Play("IdleRight");
    }
}
