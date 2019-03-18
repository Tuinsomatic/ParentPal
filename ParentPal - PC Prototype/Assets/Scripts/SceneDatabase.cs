using System.Collections;
using System.Collections.Generic;
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
        scene1.option1 = new Option("Carer flies off the handle… We’ve got to go out soon – get off that blasted computer! And look at the state of this room!When is the last time you cleaned it?", scene2);
        scene1.option2 = new Option("Carer remains calm: Insert teen name, we’re leaving in half an hour.Can you finish playing your game, get changed and be ready in the kitchen by 7 o’clock.I will give you a reminder in 15 minutes. If you are still on the console, I will turn it off.", scene3);
        scene1.option3 = null;
        scene1.option4 = null;
        scene1.option5 = null;

        scene2.question = "Teen shouts back at carer";
        scene2.option1 = new Option("Storm out", scene4);
        scene2.option2 = new Option("Hit teen", scene2);
        scene2.option3 = null;
        scene2.option4 = null;
        scene2.option5 = null;

        scene3.question = "Teen replies, ok carer no worries";
        scene3.option1 = null;
        scene3.option2 = null;
        scene3.option3 = null;
        scene3.option4 = null;
        scene3.option5 = null;

        scene4.question = "You storm out";
        scene4.option1 = null;
        scene4.option2 = null;
        scene4.option3 = null;
        scene4.option4 = null;
        scene4.option5 = null;


        //scenes[0] = new Scene();
    }
}

public class Scene
{
    public string question;
    public Option option1;
    public Option option2;
    public Option option3;
    public Option option4;
    public Option option5;
    //public Sprite background = null;

    //public Scene(string q, Option o1, Option o2, Option o3, Option o4, Option o5)
    //{
    //    q = question;
    //    o1 = option1;
    //    o2 = option2;
    //    o3 = option3;
    //    o4 = option4;
    //    o5 = option5;
    //}
}

public class Option
{
    public string text;
    public Scene destination;

    public Option(string t, Scene d)
    {
        t = text;
        d = destination;
    }
}
