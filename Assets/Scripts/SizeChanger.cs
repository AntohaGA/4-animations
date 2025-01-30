using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _speedIncrease;

    private void Update()
    {
        transform.localScale += new Vector3(1,1,1) * _speedIncrease * Time.deltaTime;
    }
}