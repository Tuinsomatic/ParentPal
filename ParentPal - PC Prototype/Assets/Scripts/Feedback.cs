using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Feedback : MonoBehaviour
{

    public List<bool> feedback;
    public GameObject txt;
    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(() => Back());

        feedback = FeedbackTransfer.feedbackData;

        if (FeedbackTransfer.scenarioNumber == 1)
        {
            if (feedback[0] == true && feedback[1] == true && feedback.Count == 2)
            {
                txt.GetComponent<Text>().text = "Well done! By remaining calm and being patient with the teen, they have done as they were asked. The teen was ready in time for the family outing and plans all went ahead!";
            }
            else if (feedback[0] == false && feedback[1] == true && feedback[2] == true)
            {
                txt.GetComponent<Text>().text = "Good job. Although you got angry at first, you realised anger wasn't going to resolve anything. The teen realised this too and did as they were asked. The teen was ready in time for the family outing and plans all went ahead!";
            }
            else if (feedback[0] == false && feedback[1] == true && feedback[2] == false)
            {
                txt.GetComponent<Text>().text = "You almost had it! You got angry at first and calmed down realising anger wouldn't resolve anything. However when the teen didn't cooperate at first you got angry again and subsequently angered the teen. The teen shut down because you turned off their games console.";
            }
            else if (feedback[0] == true && feedback[1] == false && feedback.Count == 2)
            {
                txt.GetComponent<Text>().text = "You nearly had it! You remained calm at first and the teen respected your request, however you lost your cool when the teen wasn't showing any signs of getting ready. The teen shut down because you turned off their games console.";
            }
            else //(feedback[0] == false && feedback[1] == false && feedback.Count == 2)
            {
                txt.GetComponent<Text>().text = "Be careful! Using anger against someone - especially a hormonal teenager - won't resolve any issues you have! Try again another time, and try bargaining with the teen. The teen shut down because you were showing aggression to them and vice versa.";
            }
        }
        if (FeedbackTransfer.scenarioNumber == 2)
        {
            if (feedback[0] == true)
            {
                txt.GetComponent<Text>().text = "Well done! By sitting with the children and resolving the issue they were fighing about with them, you have calmed them down and they are now playing their game nicely.";
            }
            else
            {
                txt.GetComponent<Text>().text = "Be careful! Getting angry/aggressive to children in this situation can scare them or make them retaliate, often worsening te situation. In this case, the children ran upstairs crying in response to your anger.";
            }
        }
    }

    void Back()
    {
        SceneManager.LoadScene("ScenarioSelection");
    }
}
