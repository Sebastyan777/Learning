using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject Bullet;
    public Transform Position;
    public float ShotForce = 500f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shot();
    }

    private void Shot()
    {
        var exBullet = Instantiate(Bullet, Position.position, Position.rotation);

        var ExRBBullet = exBullet.GetComponent<Rigidbody>();
        ExRBBullet.AddForce(Position.forward * ShotForce, ForceMode.Impulse);
    }
}
