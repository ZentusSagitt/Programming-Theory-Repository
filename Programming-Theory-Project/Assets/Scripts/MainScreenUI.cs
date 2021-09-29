using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreenUI : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToTitleScreen();    // ABSTRACTION
        }
    }

    void ToTitleScreen()
    {
        SceneManager.LoadScene(0);
    }
}
