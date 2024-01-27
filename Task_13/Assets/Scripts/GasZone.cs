using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Gaz : MonoBehaviour
{
    private BoxCollider _boxCollider;

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
        _boxCollider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            Debug.Log($"{other.gameObject.name} in Gas Zone");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            Debug.Log($"{other.gameObject.name} left the Gas Zone");
    }
}
