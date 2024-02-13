using UnityEngine;

public class Cube : MonoBehaviour
{
    private GameObject cube;

    public void Start()
    {
        cube = new GameObject("Cube", typeof(Rigidbody), typeof(MeshFilter));
    }
}
