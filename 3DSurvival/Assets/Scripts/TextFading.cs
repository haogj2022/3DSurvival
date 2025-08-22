using UnityEngine;
using TMPro;
using System.Collections;

public class TextFading : MonoBehaviour
{
    TMP_Text targetText;
    BoxCollider triggerBox;

    float duration = 1f;
    float delay = 3f;

    private void Start()
    {
        targetText = GetComponent<TMP_Text>();
        triggerBox = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(FadeIn(duration));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(FadeOut(duration));
        }
    }

    IEnumerator FadeIn(float duration)
    {
        triggerBox.enabled = false;
        Color startColor = targetText.color;
        startColor.a = 0f;
        Color endColor = targetText.color;
        endColor.a = 1f;
        float timer = 0f;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            targetText.color = Color.Lerp(startColor, endColor, timer / duration);
            yield return null;
        }
        targetText.color = endColor;
        yield return new WaitForSeconds(delay);
        StartCoroutine(FadeOut(duration));
    }

    IEnumerator FadeOut(float duration)
    {
        triggerBox.enabled = false;
        Color startColor = targetText.color;
        startColor.a = 1f;
        Color endColor = targetText.color;
        endColor.a = 0f;
        float timer = 0f;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            targetText.color = Color.Lerp(startColor, endColor, timer / duration);
            yield return null;
        }
        targetText.color = endColor;
    }
}
