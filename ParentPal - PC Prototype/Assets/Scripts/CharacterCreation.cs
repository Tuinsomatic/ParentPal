using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreation : MonoBehaviour
{
    // Start is called before the first frame update
    Button button;

    public GameObject maleTopOption1;
    public GameObject maleTopOption2;
    public GameObject maleTopOption3;

    public GameObject maleBottomOption1;
    public GameObject maleBottomOption2;
    public GameObject maleBottomOption3;

    //public GameObject hairOption;
    //public GameObject hairColour;
    //public GameObject skinColour;

    void Start()
    {
        maleTopOption1.SetActive(false);
        maleTopOption2.SetActive(false);
        maleTopOption3.SetActive(false);

        maleBottomOption1.SetActive(false);
        maleBottomOption2.SetActive(false);
        maleBottomOption3.SetActive(false);

    }

    void ButtonPress()
    {
        button.onClick.AddListener(() => ch);
    }

    void CharacterEdit()
    {

    }
}

