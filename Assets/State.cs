using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scriptable Objects do not require a GameObject component.
//Instead, we implement them as objects we can utilize in the Unity editor
//We do this using the CreateAssetMenu attribute, which allows us to create an item in the Create Asset menu
[CreateAssetMenu(menuName = "State")]


public class State : ScriptableObject
{
    //SerializeField attribute will make whatever we append it to available in our inspector
    
    
//The [TextArea(min,max)] attribute creates a wrappable textbox.
//The first argument, min, is the default number of lines (aka height) of the text box
//The second argument, max, is the number of lines the box can expand to before it becomes scrollable

//So here, the StoryText text box is 10 lines in height by default, can be no smaller than that.
//Then, we can expand it up to 14 total lines, after which it will become scrollable
[TextArea(10,14)] [SerializeField] string StoryText;


[SerializeField] State[] NextStates;
    public string GetStateStory() {
        return StoryText;
    }

    public State[] GetNextStates() {
        return NextStates;
    }
}
