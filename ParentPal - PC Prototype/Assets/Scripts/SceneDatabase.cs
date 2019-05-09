using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneDatabase : MonoBehaviour
{
    public Scenario scene1 = new Scenario();
    public Scenario scene2 = new Scenario();
    public Scenario scene3 = new Scenario();
    public Scenario scene4 = new Scenario();
    public Scenario scene5 = new Scenario();

    public Scenario scene6 = new Scenario();
    public Scenario scene7 = new Scenario();
    public Scenario scene8 = new Scenario();

    public Scenario current;

    //---------------------------------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        scene1.question = "Teen sat playing on games console in messy bedroom. Carer knocks on the door and walks in…";
        scene1.optionT.Add("Remain calm & ask teen to be ready to go out in the kitchen soon");
        scene1.optionT.Add("Get MAD & comment on state of bedroom");
        scene1.optionD.Add(scene4);
        scene1.optionD.Add(scene2);
        scene1.optionG.Add(true);
        scene1.optionG.Add(false);
        scene1.scenarioNumber = 1;


        scene2.question = "Teen shouts back at carer";
        scene2.optionT.Add("Remain angry");
        scene2.optionT.Add("Back down, but give a warning that the console is coming off if the teen isn't ready soon");
        scene2.optionD.Add(scene3);
        scene2.optionD.Add(scene4);
        scene2.optionG.Add(false);
        scene2.optionG.Add(true);
        scene2.scenarioNumber = 1;

        scene3.question = "Both you and teen are angry and upset. Teen shuts down, refuses to go out. Evening ruined";
        scene3.isEnd = true;
        scene3.scenarioNumber = 1;


        scene4.question = "Teen replies: \"no worries\". 15 mins later, carer comes back in to remind teen to be ready soon.";
        scene4.optionT.Add("Turn console off and give 15 minute warning");
        scene4.optionT.Add("Give 15 minute warning");
        scene4.optionD.Add(scene3);
        scene4.optionD.Add(scene5);
        scene4.optionG.Add(false);
        scene4.optionG.Add(true);
        scene4.scenarioNumber = 1;

        scene5.question = "Teen is ready and downstairs on time. Evening out goes forward as planned.";
        scene5.isEnd = true;
        scene5.scenarioNumber = 1;


        scene6.question = "Carer preparing dinner in the kitchen and can hear the kids start arguing in the lounge over a game, who gets to go first";
        scene6.optionT.Add("Ask children what the problem is");
        scene6.optionT.Add("Get mad, threaten to take game away");
        scene6.optionD.Add(scene8);
        scene6.optionD.Add(scene7);
        scene6.optionG.Add(true);
        scene6.optionG.Add(false);
        scene6.scenarioNumber = 2;

        scene7.question = "Children continue to argue despite threat. Carer takes game away, children run to their rooms crying";
        scene7.isEnd = true;
        scene7.scenarioNumber = 2;

        scene8.question = "Children and carer resolve problem together, children continue playing game happily";
        scene8.isEnd = true;
        scene8.scenarioNumber = 2;

        if (FeedbackTransfer.scenarioNumber == 1)
        {
            current = scene1; 
        }
        if (FeedbackTransfer.scenarioNumber == 2)
        {
            current = scene6;
        }
    }
}

