using UnityEngine;

public class Resizer : StateChanger
{
    [SerializeField] private float _speed;

    protected override void ChangeState()
    {
        transform.localScale += Vector3.one * _speed;
    }
}
