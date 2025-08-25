using UnityEngine;

public class PushForward : MonoBehaviour
{
    public float pushForce = 30f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * pushForce, ForceMode.Acceleration);
        }
    }
}
