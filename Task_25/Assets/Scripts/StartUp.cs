using UnityEngine;
using UnityEngine.Events;

public class StartUp : MonoBehaviour
{
    private Player _player;
    private delegate void Delegate();
    private Delegate _delegate;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _player.MoveEvent.AddListener(Notify);

        _delegate = Notify;
        _delegate.Invoke();
        OtherMethod();
    }

    public void Notify()
    {

    }

    public void OtherMethod()
    {

    }
}
