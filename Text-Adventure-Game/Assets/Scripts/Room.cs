using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/Room")]

public class Room : ScriptableObject  //which means can be used to create asset which
                                      // store data and excute code. diffrerence from mona behaviour not attached to game objects

{

    [TextArea] public string description;  // textarea allows more space
    public string roomName;
    public Exit[] exits;
    public InteractableObject[] interactableObjectsInRoom;






}
