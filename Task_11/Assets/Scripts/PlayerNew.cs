using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNew : MonoBehaviour
{
    public Rigidbody rb;
    public int jumpforce;
    public bool isGrounded = true;
    public int jumps = 2;
    public float RotationSpeed = 5;
    public float Speed = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        jumps = 2;
    }


    public void Jump()
    {
        jumps--;

        if (isGrounded && jumps > 0)
            rb.AddForce(Vector2.up * jumpforce, ForceMode.Impulse);
        else if (isGrounded && jumps <= 0)
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            Jump();

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = (Camera.main.transform.forward * vertical + Camera.main.transform.right * horizontal).normalized;
        
        if (direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * RotationSpeed);
        }

        rb.MovePosition(transform.position + direction * Speed * Time.deltaTime);
    }
}
