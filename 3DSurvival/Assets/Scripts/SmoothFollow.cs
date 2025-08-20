using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    Transform target;
    public Vector3 offset;   
    public float smoothTime = 0.3f;

    private Vector3 currentVelocity = Vector3.zero;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
        }
    }
}
