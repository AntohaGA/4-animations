using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _speed * Time.deltaTime, 0);
    }
}