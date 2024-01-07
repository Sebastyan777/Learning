using UnityEngine;

public class PrefabRespawn : MonoBehaviour
{
    public GameObject Prefab;

    private void Start()
    {
        var cube1 = Instantiate(Prefab, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0), transform);
        var cube2 = Instantiate(Prefab, new Vector3(2, 0, 2), Quaternion.Euler(0, 0, 0), transform);
        var cube3 = Instantiate(Prefab, new Vector3(-2, 0, 2), Quaternion.Euler(0, 0, 0), transform);

        MeshRenderer colorCube1 = cube1.GetComponent<MeshRenderer>();
        colorCube1.material.color = Color.green;
        MeshRenderer colorCube2 = cube2.GetComponent<MeshRenderer>();
        colorCube2.material.color = Color.blue;
        MeshRenderer colorCube3 = cube3.GetComponent<MeshRenderer>();
        colorCube3.material.color = Color.red;

        var rb1 = cube1.AddComponent<Rigidbody>();
        rb1.useGravity = false;
        var rb2 = cube2.AddComponent<Rigidbody>();
        rb2.useGravity = false;
        var rb3 = cube3.AddComponent<Rigidbody>();
        rb3.useGravity = false;
    }
}
