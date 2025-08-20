using UnityEngine;

public class PushForward : MonoBehaviour
{
    public float pushForce = 3f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * pushForce * 10f, ForceMode.Acceleration);
        }
    }
}
