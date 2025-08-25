using UnityEngine;
using UnityEngine.UI;

public class HealthDecline : MonoBehaviour
{
    public float maxHealth = 50f;

    float currentHealth = 0f;
    float declineSpeed = 2f;
    bool canDecline = false;
    Slider playerHealth;

    void Start()
    {
        currentHealth = maxHealth;
        playerHealth = GetComponentInChildren<Slider>();
        playerHealth.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LightZone")
        {
            if (currentHealth < maxHealth)
            {
                currentHealth += 1;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnableHealth")
        {
            playerHealth.gameObject.SetActive(true);
        }

        if (other.tag == "SafeZone")
        {
            canDecline = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "SafeZone")
        {
            canDecline = true;
        }
    }

    void Update()
    {
        if (playerHealth.gameObject.activeSelf)
        {
            if (canDecline)
            {
                currentHealth -= Time.deltaTime * declineSpeed;
                playerHealth.value = currentHealth / maxHealth;
            }
        }
    }
}
