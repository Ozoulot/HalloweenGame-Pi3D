using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipPick : MonoBehaviour
{
    public Canvas uiClip; //Reference to the Canvas component in Unity hierarchy.
    public GameObject Clipboard; //Reference to the Gameobject Clipboard in the Unity hierarchy.
    public Rigidbody rb; //Reference to the Gameobject Clipboards' rigidbody.
    public Transform hand; //Reference to the Gameobject hand in the Unity hierarchy, which will work as the players hand.
    public float pickUpRange; //A float to set the range in which the item can be picked up from.
    public Transform player; //Reference to the player object in the Unity hierachy.
    public BoxCollider coll; //Reference to the Clipboards boxcollider.
    public Transform pCam; //Reference to the main camera, also known as FPSCam.
    

    public bool equipped; //Boolean to set equipped to true/false, to determine if the player can pick up an item or not.
    public static bool slotFull; //Boolean that will check if the player already has an item in the hand.

    private void Start() //Start is called before the first frame update.
    {
        if (!equipped) //If statement that checks if the player does not have the item equipped, then..
        {
            uiClip.enabled = false; //If not equipped then the UI is disabled/invisible.
            rb.isKinematic = false; //The object Clipboard in the game scene will not be kinematic and use physics.
            slotFull = false; //No item is equipped so the slotFull bool is false.
        }
        if (equipped) //If statement checking if the player has the item equipped, then..
        {
            uiClip.enabled = true; //Enable the clipboard UI
            rb.isKinematic = true; //Set the object to Kinematic, and not be affected by physics.
            slotFull = true; //The player has an item equipped so the bool will be set to true.
        }
    }

    void Update() //Update runs once pr. frame.
    {
        Vector3 distanceToPlayer = player.position - transform.position; //Vector3 is a representation of 3D vectors. Calculate the distance from the player to the object by taking the players position and subtracting it from the objects position.
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull) PickUp(); //If statement that checks if the player is in pickuprange and pressing E on the keyboard, if yes, then run PickUp() function.

        if (equipped && Input.GetKeyDown(KeyCode.L)) ShowPaper(); //If statement that checks if the player has the clipboard equipped and presses L on the keyboard, if yes, then run the ShowPaper() function.
    }

    void PickUp() //Will run if the player is in pickuprange of the object and pressing E on the keyboard.
    {
        equipped = true; //The player picks up the item, so set the boolean to true.

        GetComponent<MeshRenderer>().enabled = false; //Disable the MeshRenderer for the clipboard, making it invisible without disabling the object - it is needed to keep opening the UI
        GetComponent<Collider>().enabled = false; //Disables the collider attached to the clipboard as it doesnt need to collide with anything anymore.

        uiClip.enabled = true; //Upon pickup the UI of the clipboard will open, so enable the canvas in the hierarchy.
    }

    void ShowPaper() //Will run if the player has picked up the clipboard and presses L on the keyboard.
    {
            if (uiClip.enabled == false) //If statement that checks if the UI is disabled, if yes then..
            {
                uiClip.enabled = true; //Enable the UI in the hierarchy.
        }
            else //If the UI is enabled then..
            {
                uiClip.enabled = false; //Disable the UI in the hierarchy.
        }
    }
}

