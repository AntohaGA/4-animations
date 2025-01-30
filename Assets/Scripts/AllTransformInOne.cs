using UnityEngine;

public class AllTransformInOne : MonoBehaviour
{
    [SerializeField] private float _speedIncrease = 1.001f;
    [SerializeField] private float _speedRotation = 1;
    [SerializeField] private float _speedMove = 0.1f; 

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _speedRotation, 0);
        transform.localScale *= _speedIncrease;
        transform.Translate(gameObject.transform.forward);
    }
}