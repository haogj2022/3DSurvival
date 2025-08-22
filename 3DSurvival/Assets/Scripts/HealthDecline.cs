using UnityEngine;
using UnityEngine.UI;

public class HealthDecline : MonoBehaviour
{
    public Slider playerHealth;
    public float maxHealth = 50f;

    float currentHealth = 0f;
    bool healthDecline = false;

    void Start()
    {
        currentHealth = maxHealth;
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
            healthDecline = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "SafeZone")
        {
            healthDecline = true;
        }
    }

    void Update()
    {
        if (playerHealth.gameObject.activeSelf)
        {
            if (healthDecline)
            {
                currentHealth -= Time.deltaTime * 2f;
            }
            playerHealth.value = currentHealth / maxHealth;
        }
    }
}
