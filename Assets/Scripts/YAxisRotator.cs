using UnityEngine;

public class YAxisRotator : StateChanger
{
    [SerializeField] private float _speed;

    protected override void ChangeState()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}
