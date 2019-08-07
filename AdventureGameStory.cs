using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGameStory : MonoBehaviour
{
    [SerializeField] Text storytext;
    [SerializeField] State startingState;
    [SerializeField] Text storytextchoices01;
    [SerializeField] Text storytextchoices02;
    [SerializeField] Text storytextchoices03;

    public Button option01, option02, option03;

    State currentState;

    // Start is called before the first frame update
    void Start()
    {
        option01.onClick.AddListener(ManageButton01);
        option02.onClick.AddListener(ManageButton02);
        option03.onClick.AddListener(ManageButton03);

        currentState = startingState;
        storytext.text = currentState.GetStateStory();
        storytextchoices01.text = currentState.GetStateStoryChoices01();
        storytextchoices02.text = currentState.GetStateStoryChoices02();
        storytextchoices03.text = currentState.GetStateStoryChoices03();
    }


    // Update is called once per frame
    void Update()
    {

        ManageState();
       // ButtonClean();
    }

    private void ManageState()
    {
        var nextStates = currentState.getnextStates();

        for(int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1+i))
            {
                currentState = nextStates[i];

            }
        }

        storytext.text = currentState.GetStateStory();
        storytextchoices01.text = currentState.GetStateStoryChoices01();
        storytextchoices02.text = currentState.GetStateStoryChoices02();
        storytextchoices03.text = currentState.GetStateStoryChoices03();
    }

    private void ManageButton01()
    {
        var nextStates = currentState.getnextStates();
        currentState = nextStates[0];

        storytext.text = currentState.GetStateStory();
        storytextchoices01.text = currentState.GetStateStoryChoices01();
        storytextchoices02.text = currentState.GetStateStoryChoices02();
        storytextchoices03.text = currentState.GetStateStoryChoices03();
    }

    private void ManageButton02()
    {
        var nextStates = currentState.getnextStates();
        currentState = nextStates[1];

        storytext.text = currentState.GetStateStory();
        storytextchoices01.text = currentState.GetStateStoryChoices01();
        storytextchoices02.text = currentState.GetStateStoryChoices02();
        storytextchoices03.text = currentState.GetStateStoryChoices03();
    }


    private void ManageButton03()
{
    var nextStates = currentState.getnextStates();
    currentState = nextStates[2];

    storytext.text = currentState.GetStateStory();
    storytextchoices01.text = currentState.GetStateStoryChoices01();
    storytextchoices02.text = currentState.GetStateStoryChoices02();
    storytextchoices03.text = currentState.GetStateStoryChoices03();
}

   
}

