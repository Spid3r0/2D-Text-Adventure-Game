using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="TextAdventure/InputActions/Take")]
public class Take : InputAction
{

    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {

        Dictionary<string, string> takeDictinonary = controller.interactableItems.Take(separatedInputWords);

        if (takeDictinonary != null)
        {
           controller.LogStringWithReturn( controller.TestVerbDictionaryWithNoun(takeDictinonary, separatedInputWords[0], separatedInputWords[1]));
        }
        
    }
}
