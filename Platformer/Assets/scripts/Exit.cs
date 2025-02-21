using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    [SerializeField] float levelLoadDelay = 2.0f;

    [SerializeField] float sloMoFactor = 0.2f;

    [SerializeField] private AudioClip exitSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextLevel());
    }
    IEnumerator LoadNextLevel()
    {
        Time.timeScale = sloMoFactor;

        yield return new WaitForSecondsRealtime(levelLoadDelay);

        //AudioSource

        Time.timeScale = 1.0f;

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex +1);
    }

}
