using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public SceneDatabase database;

    public Button op1;
    public Button op2;

    public List<bool> goodDecision = new List<bool>();
    void Start()
    {
        op1.onClick.AddListener(() => ChangeScene(GameObject.Find("Option1Text").GetComponent<Destination>().nextDest));
        op2.onClick.AddListener(() => ChangeScene(GameObject.Find("Option2Text").GetComponent<Destination>().nextDest));

        ChangeScene(database.current);

        FeedbackTransfer.feedbackData = null;
    }

    public void ChangeScene(Scene scene) //the fn used to change scenes when a button is pressed
    {
        GameObject q = GameObject.Find("Question"); //Question is the Text UI element at the top of the screen
        q.GetComponent<Text>().text = scene.question; //Replace the text on it with the question text from scene

        if (scene.isEnd == false)
        {
            for (int i = 0; i <= scene.optionT.Count; i++)
            {
                GameObject buttonText = GameObject.Find("Option" + (i + 1).ToString() + "Text");
                buttonText.GetComponent<Text>().text = scene.optionT[i];
                buttonText.GetComponent<Destination>().nextDest = scene.optionD[i];
                buttonText.GetComponent<Destination>().decision = scene.optionG[i];
            }
        }
        else
        {
            for (int i = 0; i <= 2; i++)
            {
                GameObject button = GameObject.Find("Option" + (i + 1).ToString());
                button.SetActive(false);
                FeedbackTransfer.feedbackData = goodDecision;
                FeedbackTransfer.previousScenario = 1;
                SceneManager.LoadScene("Feedback");
            }
        }

        current = scene;
    }
}
public class Scene
{
    public string question;
    public List<string> optionT = new List<string>();
    public List<Scene> optionD = new List<Scene>();
    public List<bool> optionG = new List<bool>();
    public bool isEnd = false;
}
