using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    private Animator _animator;
    private float _horizontal;
    private float _vertical;
    public float Speed = 5f;

    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        particle.Stop();

        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        if (_horizontal != 0 || _vertical != 0)
        {
            _animator.Play("Run");
            transform.position += new Vector3(_horizontal, 0, _vertical) * Speed * Time.deltaTime;
        }
        else
            _animator.Play("Idle");
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.collider.gameObject.layer == 3)
        {
            if (_horizontal != 0 || _vertical != 0)
                particle.Play();
            else
                particle.Stop();
        }
        else
            particle.Stop();
    }
}
