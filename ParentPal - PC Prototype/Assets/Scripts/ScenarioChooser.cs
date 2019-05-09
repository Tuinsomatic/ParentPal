using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenarioChooser : MonoBehaviour
{
    public Button button;
    public int scenarioDestination;

    private void Start()
    {
        button.onClick.AddListener(() => SelectScene());
    }

    private void SelectScene()
    {
        FeedbackTransfer.scenarioNumber = scenarioDestination;
        SceneManager.LoadScene("Scenario"+scenarioDestination);
    }
}
