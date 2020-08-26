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
        
    }
}
