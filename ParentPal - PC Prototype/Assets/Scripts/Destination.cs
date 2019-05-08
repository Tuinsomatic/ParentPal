using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destination : MonoBehaviour {

    public SceneDatabase sceneDatabase;

    public Scene nextDest;
    public bool decision;

    public Button thisButton;

    // Use this for initialization
    void Start () {
        thisButton.onClick.AddListener(() => RecordDecision());
    }

    // Update is called once per frame
    void RecordDecision()
    {
        sceneDatabase.goodDecision.Add(decision);
    }
}
