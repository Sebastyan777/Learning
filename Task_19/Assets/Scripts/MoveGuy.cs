using UnityEngine;

public class MoveGuy : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _rbGuy;
    private Animator _animator;
    private bool _isMove;
    private Vector2 _moveVector;

    private void Awake()
    {
        _rbGuy = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

        _rbGuy.gravityScale = 0f;
    }

    private void Update()
    {
        _moveVector.x = Input.GetAxis("Horizontal");
        _moveVector.y = Input.GetAxis("Vertical");

        if (_moveVector.x != 0 || _moveVector.y != 0)
            _isMove = true;
        else
            _isMove = false;

        _animator.SetBool("IsMove", _isMove);
        _animator.SetFloat("Horizontal", _moveVector.x);
        _animator.SetFloat("Vertical", _moveVector.y);

        _rbGuy.MovePosition(_rbGuy.position + _moveVector * Speed * Time.deltaTime);
    }
}
