using UnityEngine;

public class SizeRaise : MonoBehaviour
{
    [SerializeField] private float SpeedIncrease = 1.001f;

    private void Start()
    {
        SpeedIncrease = 1.001f;
    }

    private void Update()
    {
        transform.localScale *= SpeedIncrease;
    }
}