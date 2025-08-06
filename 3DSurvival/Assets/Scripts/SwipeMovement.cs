using UnityEngine;

public class SwipeMovement : MonoBehaviour
{
    Vector3 startPos, endPos, direction;

    public float moveDistance = 50f;

    Rigidbody rb;
    Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
        rb.useGravity = false;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            rb.useGravity = true;
            anim.SetTrigger("swimming");
            endPos = Input.GetTouch(0).position;
            direction = endPos - startPos;
            rb.AddForce(direction.normalized * moveDistance, ForceMode.VelocityChange);
        }

        //smooth rotate to face swipe direction
        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
        }
    }
}
