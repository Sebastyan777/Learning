using UnityEngine;

public class CubeMovementAndColor : MonoBehaviour
{
    private Transform _cubeTransform;
    private MeshRenderer _cubeMeshRenderer;

    private void Awake()
    {
        _cubeTransform = gameObject.GetComponent<Transform>();
        _cubeMeshRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        _cubeTransform.position = new Vector3(1, 1, 2);
        _cubeMeshRenderer.material.color = Color.red;

        var rb = gameObject.AddComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePosition;
    }
}
