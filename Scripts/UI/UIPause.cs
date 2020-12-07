using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPause : MonoBehaviour
{
    public GameObject PauseScreen;

    public void Pause()
    {
        PauseScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        PauseScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
