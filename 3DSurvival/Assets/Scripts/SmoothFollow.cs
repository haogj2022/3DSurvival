using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;   
    public float smoothTime = 0.3f;

    private Vector3 currentVelocity = Vector3.zero;

    void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
    }
}
