using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Animator _animator;
    private float _rotationSpeed = 2;
    private float _speed;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float movementDirectionX = Input.GetAxis("Horizontal");
        float movementDirectionY = Input.GetAxis("Vertical");

        if (movementDirectionX != 0f || movementDirectionY != 0f)
            Movement(movementDirectionX, movementDirectionY);
        else
        {
            _speed = 0f;
            _animator.SetFloat("Speed", _speed);
        }
    }

    private void Movement(float dirX, float dirY)
    {
        if (_speed < 5f)
            _speed += 0.2f;

        _animator.SetFloat("Speed", _speed);

        Vector3 direction = (Camera.main.transform.forward * dirY + Camera.main.transform.right * dirX).normalized;
        
        if (direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * _rotationSpeed);
        }

        _rigidbody.MovePosition(transform.position + direction * _speed * Time.deltaTime);
    }
}
