using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public string playerTag = "Ball";
    public string nextSceneName;
    private bool finished;
    public Image screenBackground;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (finished)
            return;
        if (!collision.gameObject.CompareTag(playerTag))
            return;

        finished = true;

        //SceneManager.LoadScene(nextSceneName);
    }
    private void FixedUpdate()
    {
        UpdateScrrenBackground();
    }
    private void UpdateScrrenBackground()
    {
        if (!finished)
            return;
        if(screenBackground.color.a >= 1f)
        {
            SceneManager.LoadScene(nextSceneName);
            enabled = false;
        }
        var color = screenBackground.color;
        color.a += 0.02f;
        screenBackground.color = color;
    }
}
