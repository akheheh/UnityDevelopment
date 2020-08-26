using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text TextComponent;
    [SerializeField] State StartingState;

    State state;
    void Start()
    {
        state = StartingState;
        TextComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState() {
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            state = nextStates[0];
        } else if(Input.GetKeyDown(KeyCode.Alpha2)) {
            state = nextStates[1];
        } else if(Input.GetKeyDown(KeyCode.Alpha3)) {
            state = nextStates[2];
        }

        TextComponent.text = state.GetStateStory();
    }
}
