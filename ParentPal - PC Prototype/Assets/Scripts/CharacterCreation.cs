using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreation : MonoBehaviour
{
    // Start is called before the first frame update
    public Button topButton;

    public GameObject maleTopOption1;
    public GameObject maleTopOption2;
    public GameObject maleTopOption3;

    public GameObject maleBottomOption1;
    public GameObject maleBottomOption2;
    public GameObject maleBottomOption3;

    //public GameObject hairOption;
    //public GameObject hairColour;
    //public GameObject skinColour;

    int i;

    void Start()
    {
        maleTopOption2.SetActive(false);
        maleTopOption3.SetActive(false);

        maleBottomOption1.SetActive(false);
        maleBottomOption2.SetActive(false);
        maleBottomOption3.SetActive(false);

        i = 0;
        ButtonPressCounter();
    }

    public void ButtonPressCounter()
    {
        topButton.onClick.AddListener(() => TopEdit());
    }

    public void TopEdit()
    {

        if(i == 0)
        {
            maleTopOption1.SetActive(true);
            maleTopOption2.SetActive(false);
            maleTopOption3.SetActive(false);
        }
        if(i == 1)
        {
            maleTopOption2.SetActive(true);
            maleTopOption1.SetActive(false);
            maleTopOption3.SetActive(false);
        }
        if(i == 2)
        {
            maleTopOption3.SetActive(true);
            maleTopOption1.SetActive(false);
            maleTopOption2.SetActive(false);
        }
        if (i > 2)
        {
            i = 0;
        }
        i++;

    }
}

