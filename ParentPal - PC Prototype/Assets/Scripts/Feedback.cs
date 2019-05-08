using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feedback : MonoBehaviour
{

    public List<bool> feedback;
    public GameObject txt;

    // Start is called before the first frame update
    void Start()
    {
        feedback = FeedbackTransfer.feedbackData;

        if (FeedbackTransfer.previousScenario == 1)
        {
            if (feedback[0] == true && feedback[1] == true && feedback.Count == 2)
            {
                txt.GetComponent<Text>().text = "you did brilliantly!";
            }
            else if (feedback[0] == false && feedback[1] == true && feedback[2] == true)
            {
                txt.GetComponent<Text>().text = "you did well";
            }
            else if (feedback[0] == false && feedback[1] == true && feedback[2] == false)
            {
                txt.GetComponent<Text>().text = "you almost had it";
            }
            else if (feedback[0] == true && feedback[1] == false && feedback.Count == 2)
            {
                txt.GetComponent<Text>().text = "you nearly had it";
            }
            else //(feedback[0] == false && feedback[1] == false && feedback.Count == 2)
            {
                txt.GetComponent<Text>().text = "you did shit";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
