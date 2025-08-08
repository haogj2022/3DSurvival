using UnityEngine;

public class SwipeMovement : MonoBehaviour
{
    Vector3 startPos, endPos, direction;

    public float moveSpeed = 2.5f;
    public ParticleSystem pushDustEffect;

    float rotateSpeed = 5f;
    bool touchEnabled = true;

    float swipeForce = 10f;    
    float swipeDelay = 0.5f;
    bool canSwipe = true;

    Rigidbody rb;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
        rb.useGravity = false;
    }

    void Update()
    {
        if (touchEnabled)
        {
            HandleTouchInput();
        }
    }

    void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended && canSwipe)
            {
                pushDustEffect.Play();
                canSwipe = false;
                Invoke("SwipeEnabled", swipeDelay);
                rb.useGravity = true;
                anim.SetTrigger("swimming");
                endPos = touch.position;
                direction = endPos - startPos;
                rb.AddForce(direction.normalized * moveSpeed * swipeForce, ForceMode.Impulse);
            }
        }

        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotateSpeed);
        }
    }

    void SwipeEnabled()
    {
        canSwipe = true;
    }
}
