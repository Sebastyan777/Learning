using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Yula : MonoBehaviour
{
    private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _rigidBody.AddTorque(0,100,0);
        else if (Input.GetKeyDown(KeyCode.RightShift))
            _rigidBody.angularVelocity = Vector3.zero;
    }
}
