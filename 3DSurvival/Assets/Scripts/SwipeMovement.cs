using UnityEngine;

public class SwipeMovement : MonoBehaviour
{
    Vector3 startPos, endPos, direction;

    public float moveSpeed = 2.5f;
    public ParticleSystem pushDustEffect;

    bool touchEnabled = true;
    float rotateSpeed = 5f;
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
                anim.Play("Swim", 0, 0.5f);
                endPos = touch.position;
                direction = endPos - startPos;
                rb.AddForce(direction.normalized * moveSpeed * swipeForce, ForceMode.Impulse);
            }
        }
        RotateTowardsDirection();
    }

    void SwipeEnabled()
    {
        canSwipe = true;
    }

    void RotateTowardsDirection()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
    }
}
