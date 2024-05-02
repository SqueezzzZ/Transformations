using UnityEngine;

public class ForwardMover : StateChanger
{
    [SerializeField] private float _speed;

    protected override void ChangeState()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
