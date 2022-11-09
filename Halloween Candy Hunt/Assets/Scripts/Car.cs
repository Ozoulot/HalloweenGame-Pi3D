using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{ 
    public Canvas gameOver; //Reference to the gameover canvas in the Unity hierarchy.
    public Rigidbody rb; //Gets the Gameobject Vehicles' rigidbody.
    public float interactionRange; //Sets a range in which the player can interact with the car.
    public Transform player; //Reference to the player object.
    public BoxCollider coll; //Gets the Vehicles' box collider.
    public Transform pCam; //Reference to the FPSCam attached to the player.
    public GameObject Vehicle; //Reference to the Gameobject Vehicle, which contains the car.

    void Start() //Start is called before the first frame update.
    {
        gameOver.enabled = false; //Disables the gameover UI when the game starts.
    }
    void Update()
    {
        Vector3 distanceToPlayer = player.position - transform.position; //Vector3 is a representation of 3D vectors. Calculate the distance from the player to the object by taking the players position and subtracting it from the objects position.
        if (distanceToPlayer.magnitude <= interactionRange && Input.GetKeyDown(KeyCode.E)) End(); //If statement that checks if the player is in interactionrange and pressing E on the keyboard, if yes, then run the End() function.
    }

void End() //End() is called when the player is in interactionrange of the car and pressing E.
    { 
            if (gameOver.enabled == false) //If statement that checks if the gameover UI is enabled, if not then..
            {
                gameOver.enabled = true; //Enable the gameover UI.
                Cursor.lockState = CursorLockMode.None; //Unlock the cursor from the middle of the screen.
                Cursor.visible = true; //Make the cursor visible.
            }
    }
}