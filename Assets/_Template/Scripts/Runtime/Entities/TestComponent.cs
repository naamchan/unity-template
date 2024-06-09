using UnityEngine;

public class TestComponent : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = transform.position with { y = 0f };
            Debug.Log($"Down {transform.position}");
        }
    }
}
