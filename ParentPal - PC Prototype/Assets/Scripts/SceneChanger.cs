using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour {

    public SceneDatabase scenes = new SceneDatabase();
    public Scene currentScene;

    void Start () {
        currentScene = scenes.scene1;
        ChangeScene(); //Scenario 1 is the first one to be loaded (for now)
	}

    public void ChangeScene() //the fn used to change scenes when a button is pressed
    {
        GameObject q = GameObject.Find("Question"); //Question is the Text UI element at the top of the screen
        GameObject o1 = GameObject.Find("Option1Text");
        GameObject o2 = GameObject.Find("Option2Text");

        q.GetComponent<Text>().text = currentScene.question; //Replace the text on it with the question text from scene
        o1.GetComponent<Text>().text = currentScene.option1.text;
        o2.GetComponent<Text>().text = currentScene.option2.text;
    }
}
