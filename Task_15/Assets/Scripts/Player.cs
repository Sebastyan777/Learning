using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float movementDirectionX = Input.GetAxis("Horizontal");
        float movementDirectionY = Input.GetAxis("Vertical");

        transform.position = Vector3.MoveTowards(transform.position, transform.position += new Vector3(movementDirectionX, 0, movementDirectionY), 2 * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
            _rigidBody.AddForce(0, 200, 0);
    }
}
