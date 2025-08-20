using UnityEngine;
using TMPro;

public class TextFading : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<TMP_Text>().color = new Color();
        }
    }
}
