using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    public float Speed = 5;
    public float RotationSpeed = 5;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = (Camera.main.transform.forward * vertical + Camera.main.transform.right * horizontal).normalized;
        
        if (direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * RotationSpeed);
        }

        _rb.MovePosition(transform.position + direction * Speed * Time.deltaTime);
    }
}
