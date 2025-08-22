using UnityEngine;

public class SwipeMovement : MonoBehaviour
{
    Vector3 startPos, endPos, moveDir;

    public float moveSpeed = 3f;
    public ParticleSystem pushDustEffect;

    bool touchEnabled = true;
    float rotateSpeed = 5f;   
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

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;
                case TouchPhase.Ended:
                    endPos = touch.position;
                    if (canSwipe && endPos != startPos)
                    {
                        canSwipe = false;
                        Invoke("SwipeEnabled", swipeDelay);
                        anim.Play("Swim", 0, 0.5f);
                        pushDustEffect.Play();
                        moveDir = endPos - startPos;
                        rb.useGravity = true;
                        rb.AddForce(moveDir.normalized * moveSpeed * 10f, ForceMode.Impulse);
                    }
                    break;
                default:
                    break;
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
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, moveDir);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
    }
}
