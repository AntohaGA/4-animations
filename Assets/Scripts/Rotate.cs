using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        _speed = 1;
    }

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _speed, 0);
    }
}