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
    public Scene scene5 = new Scene();

    public Scene current;

    public Button op1;
    public Button op2;
//---------------------------------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        scene1.question = "Teen sat playing on games console in messy bedroom. Carer knocks on the door and walks in…";
        scene1.optionT.Add("Get MAD & comment on state of bedroom");
        scene1.optionT.Add("Remain calm & ask teen to be ready to go out in the kitchen soon");
        scene1.optionD.Add(scene2);
        scene1.optionD.Add(scene4);


        scene2.question = "Teen shouts back at carer";
        scene2.optionT.Add("Remain angry");
        scene2.optionT.Add("Back down, but give a warning that the console is coming off if the teen isn't ready soon");
        scene2.optionD.Add(scene3);
        scene2.optionD.Add(scene4);

        scene3.question = "Both you and teen are angry and upset. Teen shuts down, refuses to go out. Evening ruined";
        scene3.optionT.Add("Go back");
        scene3.optionT.Add("Go back");
        scene3.optionD.Add(scene1);
        scene3.optionD.Add(scene1);


        scene4.question = "Teen replies: \"no worries\". 15 mins later, carer comes back in to remind teen to be ready soon.";
        scene4.optionT.Add("Turn console off and give 15 minute warning");
        scene4.optionT.Add("Give 15 minute warning");
        scene4.optionD.Add(scene3);
        scene4.optionD.Add(scene5);

        scene5.question = "Teen is ready and downstairs on time. Evening out goes forward as planned.";
        scene5.optionT.Add("Scenario over");
        scene5.optionT.Add("Scenario over");
        scene5.optionD.Add(scene5);
        scene5.optionD.Add(scene5);

        current = scene1;
        //for (int i = 0; i <= current.optionT.Count; i++)
        //{
        //    GameObject button = GameObject.Find("Option" + (i + 1).ToString());
        //    button.onClick.AddListener
        //}
        
        op1.onClick.AddListener(() => ChangeScene(GameObject.Find("Option1Text").GetComponent<Destination>().nextDest));
        op2.onClick.AddListener(() => ChangeScene(GameObject.Find("Option2Text").GetComponent<Destination>().nextDest));

        ChangeScene(current);
    }
//---------------------------------------------------------------------------------------------------------------------------------------
    public void ChangeScene(Scene scene) //the fn used to change scenes when a button is pressed
    {
        GameObject q = GameObject.Find("Question"); //Question is the Text UI element at the top of the screen
        q.GetComponent<Text>().text = scene.question; //Replace the text on it with the question text from scene

        for (int i = 0; i<=scene.optionT.Count; i++)
        {
            GameObject button = GameObject.Find("Option" + (i+1).ToString() + "Text");
            button.GetComponent<Text>().text = scene.optionT[i];
            button.GetComponent<Destination>().nextDest = scene.optionD[i];
        }

        current = scene;
    }
}
//---------------------------------------------------------------------------------------------------------------------------------------
public class Scene
{
    public string question;
    public List<string> optionT = new List<string>();
    public List<Scene> optionD = new List<Scene>();
}
