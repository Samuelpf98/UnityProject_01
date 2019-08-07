using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storyText;
    [TextArea(10, 14)] [SerializeField] string storyTextChoice01;
    [TextArea(10, 14)] [SerializeField] string storyTextChoice02;
    [TextArea(10, 14)] [SerializeField] string storyTextChoice03;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public string GetStateStoryChoices01()
    {
        return storyTextChoice01;
    }

    public string GetStateStoryChoices02()
    {
        return storyTextChoice02;
    }

    public string GetStateStoryChoices03()
    {
        return storyTextChoice03;
    }

    public State[] getnextStates()
    {
        return nextStates;
    }
}

