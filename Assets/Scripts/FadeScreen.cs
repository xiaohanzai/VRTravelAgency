using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScreen : MonoBehaviour
{
    public float fadeDuration = 2;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        FadeOut();
    }

    public void FadeIn()
    {
        StartCoroutine(FadeRoutine(true));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeRoutine(false));
    }

    private IEnumerator FadeRoutine(bool fadeIn)
    {
        float timer = 0;
        float deltaTime = Time.deltaTime;
        if (!fadeIn) // fade out
        {
            timer = fadeDuration;
            deltaTime *= -1;
        }
        // fade in or out
        while (timer <= fadeDuration && timer >= 0)
        {
            rend.material.color = Color.Lerp(Color.clear, Color.black, timer / fadeDuration);
            timer += deltaTime;
            yield return null;
        }
    }
}
