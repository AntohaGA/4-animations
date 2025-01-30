using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private Vector3 _direction;

    private void Awake()
    {

    }

    private void Update()
    {
        _direction = transform.forward;
        transform.localPosition += _direction * _speed * Time.deltaTime;
    }  
}