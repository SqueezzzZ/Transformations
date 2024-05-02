using UnityEngine;

public class StateChanger : MonoBehaviour
{
    protected virtual void ChangeState() { }

    private void Update()
    {
        ChangeState();
    }
}
