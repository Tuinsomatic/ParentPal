using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SceneDatabase : MonoBehaviour {

    //public List<Scene> scenes = new List<Scene>();
    public Scene scene1 = new Scene();
    public Scene scene2 = new Scene();
    public Scene scene3 = new Scene();
    public Scene scene4 = new Scene();

    private void Start()
    {
        scene1.question = "Teen sat playing on games console in messy bedroom. Carer knocks on the door and walks in…";
        scene1.optionT.Add("Get ma");
        scene1.optionT.Add("Remain clm");
        scene1.optionD.Add(scene2);
        scene1.optionD.Add(scene3);


        scene2.question = "Teen shouts back at carer";


        scene3.question = "Teen replies, ok carer no worries";


        scene4.question = "You storm out";


        ChangeScene(scene1);
        //scenes[0] = new Scene();
    }

    public void ChangeScene(Scene scene) //the fn used to change scenes when a button is pressed
    {
        GameObject q = GameObject.Find("Question"); //Question is the Text UI element at the top of the screen
        q.GetComponent<Text>().text = scene.question; //Replace the text on it with the question text from scene

        for (int i = 0; i<=scene.optionT.Count; i++)
        {
            GameObject button = GameObject.Find("Option" + (i+1).ToString() + "Text");
            button.GetComponent<Text>().text = scene.optionT[i];
        }
    }
}

public class Scene
{
    public string question;
    public List<string> optionT = new List<string>();
    public List<Scene> optionD = new List<Scene>();
}
