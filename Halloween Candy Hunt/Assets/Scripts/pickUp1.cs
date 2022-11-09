using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp1 : MonoBehaviour
{
    public Flashlight flashScript; //Reference to the script that will control the spotlight attached to the Gameobject in the Unity hierarchy.
    public Rigidbody rb; //Gets the items' rigidbody.
    public Transform hand; //Reference to the gameobject hand in the hierarchy.
    public float pickUpRange; //Does so a pickuprange can be set in the editor, which determins from how far away the player can pick up an item.
    public Transform player; //Reference to the player object in the hierarchy.
    public BoxCollider coll; //Gets the items' box collider.
    public Transform pCam; //Reference to the FPSCam in the hierarchy.

    public bool equipped; //Bool to set wether the player has an item equipped or not.
    public float dropForwardForce, dropUpwardForce; //Floats to set a value for which the item should move when dropped. dropForwardForce = how far forward it flies, and dropUpwardForce = how high it flies.
    public static bool slotFull; //Bool to check if the player already has an item equipped or not.

    private void Start() //Start is called before the first frame update.
    {
        if (!equipped) //If statement that checks if the player does not have an item equipped, if not..
        {
            flashScript.enabled = false; //Disable the flashScript that controls the spotlight.
            rb.isKinematic = false; //The rigidbody of the item uses physics.
            slotFull = false; //The item does not take up the space in the hand.
        }
        if (equipped) //If statement that checks if the player has an item equipped, if yes..
        {
            flashScript.enabled = true; //Enable the flashScript that controls the spotlight.
            rb.isKinematic = true; //The rigidbody of the item is not affected by physics.
            slotFull = true; //The item takes up the space in the hand.
        }
    }

    void Update() //Update is called once pr. frame.
    {
        Vector3 distanceToPlayer = player.position - transform.position; //Vector3 is a representation of 3D vectors. Calculate the distance from the player to the object by taking the players position and subtracting it from the objects position.
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull) PickUp(); //If statement that checks if the player does not have an item equipped, is in pickuprange and pressing E on the keyboard, if yes, then run PickUp() function.
        if (equipped && Input.GetKeyDown(KeyCode.Q)) Drop(); //If statement that checks if the player has an item equipped and pressing Q on the keyboard, if yes, then run Drop() function.
    }

    void PickUp() //Runs when the player does not have an item equipped, presses E on the keyboard and is in pickuprange of the item.
    {
        equipped = true; //Player equips the item, changes the bool to true.
        slotFull = true; //The item takes up the space in the hand, changes the bool to true.

        GetComponent<BoxCollider>().enabled = false; //Disables the boxcollider of the item.
        this.transform.position = hand.position; //Transforms the position of the item to the hand position.
        this.transform.parent = GameObject.Find("hand").transform; //Sets the hand parent to the item and transforms it.
        rb.isKinematic = true; //The rigidbody is not affected by physics.
        this.transform.localPosition = Vector3.zero; //Transforms the item to the Vector3 created earlier for the player position.
        this.transform.localRotation = Quaternion.identity; //Sets the rotation of the item to match the direction the player is looking.
        flashScript.enabled = true; //Enables the flashScript that controls the spotlight.
        coll.isTrigger = true; //Enables the boxcollider to be a trigger.
    }

    void Drop() //Runs when the player has an item equipped and presses Q on the keyboard.
     {
        equipped = false; //The player drops the item, changing the bool to false.
        slotFull = false; //The item no longer takes up the space in the hand, chaning the bool to false.

        GetComponent<BoxCollider>().enabled = true; //Enables the box collider of the item.
        rb.AddForce(pCam.forward * dropForwardForce); //Adds the dropForwardForce determined earlier to the item, mulitplied by the direction the FPSCam is moving.
                rb.AddForce(pCam.up * dropUpwardForce); //Adds the dropUpwardForce determined earlier to the item, mulitplied by the direction the FPSCam is moving.
        this.transform.parent = null; //Sets the parent of the item to null, removing it from the hand.
                rb.isKinematic = false; //The item is affected by physics again.
                flashScript.enabled = false; //Disables the flashScript that controls the spotlight.
                coll.isTrigger = false; //Disables the collider to no longer be a trigger.
     }
}