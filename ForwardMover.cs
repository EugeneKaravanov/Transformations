using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(new Vector3(_speed, 0, 0) * Time.deltaTime, Space.Self);
    }
}
