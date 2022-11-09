using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyPick : MonoBehaviour
{
    public GameObject Candy; //Reference to the Gameobject Candy in the Unity hierarchy.

    public float pickUpRange; //Does so a pickuprange can be set in the editor, which determins from how far away the player can pick up a piece of candy.
    public Transform player; //Reference to the player object in the Unity hierarchy.

    private void Update() //Update is called once pr. frame.
    {
        Vector3 distanceToPlayer = player.position - transform.position; //Vector3 is a representation of 3D vectors. Calculate the distance from the player to the object by taking the players position and subtracting it from the objects position.
        if (distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E)) PickUp(); //If statement that checks if the player is in pickuprange and pressing E on the keyboard, if yes, then run PickUp() function.
    }

    void PickUp() //Runs when the player is in pickuprange and presses E on the keyboard.
    {
        gameObject.GetComponent<AudioSource>().Play(); //Plays a eating sound.
        Candy.SetActive(false); //Disables the Candy gameobject from the scene.
     
        Score.instance.AddCount(); //Calls the instance from the score script.
    }

}