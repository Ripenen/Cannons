using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UILose : MonoBehaviour
{
    public GameObject LoseScreen;

    public void Lose()
    {
        LoseScreen.SetActive(true);
        Time.timeScale = 0;
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
