using UnityEngine;

public class Increaser : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;

    private void Update()
    {
        transform.localScale += new Vector3(_increaseSpeed, _increaseSpeed, _increaseSpeed);
    }
}
