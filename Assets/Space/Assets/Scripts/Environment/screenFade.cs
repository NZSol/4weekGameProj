using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenFade : MonoBehaviour {

	
	public void fadeOut () {
        StartCoroutine(FadeToBlack());
	}
	
	IEnumerator FadeToBlack()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
    }

    public void fadeIn()
    {
        StartCoroutine(FadeToGame());
    }

    IEnumerator FadeToGame()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
            while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime;
            yield return null;
        }
    }
}
