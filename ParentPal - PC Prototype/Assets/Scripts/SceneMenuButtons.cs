using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMenuButtons : MonoBehaviour
{

    public Button menu;
    public Button customise;

    void Start()
    {
        menu.onClick.AddListener(() => ScreenChange(1));
        customise.onClick.AddListener(() => ScreenChange(2));
    }

    void ScreenChange(int value)
    {
        if (value == 2)
        {
            SceneManager.LoadScene("CharacterCreation");
        }
        else
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

}
