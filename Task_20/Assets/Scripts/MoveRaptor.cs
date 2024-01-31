using Spine.Unity;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveRaptor : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _rbRaptor;
    private SkeletonAnimation _raptorAnim;
    private Vector2 _moveVector;

    private void Awake()
    {
        _rbRaptor = GetComponent<Rigidbody2D>();
        _rbRaptor.gravityScale = 0f;

        _raptorAnim = GetComponent<SkeletonAnimation>();
    }

    private void Update()
    {
        _moveVector.x = Input.GetAxis("Horizontal");

        Vector3 raptorScale = transform.localScale;

        if (_moveVector.x < 0)
        {
            raptorScale.x = -1;
            _raptorAnim.loop = true;
            _raptorAnim.AnimationName = "walk";
        }
        else if (_moveVector.x > 0)
        {
            raptorScale.x = 1;
            _raptorAnim.loop = true;
            _raptorAnim.AnimationName = "walk";
        }
        else if (Input.GetButtonDown("Jump"))
        {
            _raptorAnim.loop = false;
            _raptorAnim.AnimationName = "Jump";
        }

        transform.localScale = raptorScale;
        
        _rbRaptor.MovePosition(_rbRaptor.position + _moveVector * Speed * Time.deltaTime);
    }
}
