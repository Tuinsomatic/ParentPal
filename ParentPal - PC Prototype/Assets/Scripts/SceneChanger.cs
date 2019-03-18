using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour {

    public SceneDatabase scenes = new SceneDatabase();

	// Use this for initialization
	void Start () {
        ChangeScene(scenes.scene1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangeScene(Scene scene) //the fn used to change scenes when a button is pressed
    {
        GameObject q = GameObject.Find("Question");
        q.GetComponent<Text>().text = scene.question;
    }
}
