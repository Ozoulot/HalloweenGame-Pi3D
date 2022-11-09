using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller; //Reference to the players charactercontroller component
    CharacterController characterCollider; //Gives the reference another name.

    public float speed = 6f; //Sets the walkspeed with a float, set to 6.
    public float gravity = -9.81f; //Sets the gravity pull on the player with a float, set to -9.81.
    public Camera playerCamera; //Reference to the maincamera FPSCam.

    public Transform groundCheck; //Creates a reference for a groundcheck, to make sure the player does not fall through the floor.
    public float groundDistance = 0.4f; //Sets the distance between the player object and the ground.
    public LayerMask groundMask; //Creates a reference for the mask of the ground.

    float rotationX = 0; //Sets the rotation of the x-axis to 0, when starting.

    Vector3 velocity; //Creates a vector to represent the players velocity.
    bool isGrounded; //Creates a Boolean to check if the player is touching the ground (true) or not (false).
    public float lookSpeed = 2.0f; //Sets the speed the player can look around with the mouse, set to 2 with a float.

    void Start() //Start is called before the first frame update.
    {
        characterCollider = gameObject.GetComponent<CharacterController>(); //Gets the charactercontroller from the player object.

        Cursor.lockState = CursorLockMode.Locked; //Locks the cursor to the middle of the screen.
        Cursor.visible = false; //Makes the coursor invisible.
    }

    void Update() //Update is called once pr. frame.
    {
        rotationX += -Input.GetAxis("Mouse Y"); //Gets input from the mouse moving in the Y-direction, up or down.
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0); //Gets the input from the mouse moving in the X-direction, from side to side.
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0); //Transforms the cameras rotation to fit the input.

        float x = Input.GetAxis("Horizontal"); //Makes a float value, contraining the x-axis so the player can move freely along that axis.
        float z = Input.GetAxis("Vertical"); //Makes a flaot value, containting the y-axis so the player can move freely along that axis.

        Vector3 move = transform.right * x + transform.forward * z; //not using Vector3 move = new Vector3(x, 0f, z);, cause it would always be the same direction, no matter which way the player faces.

        controller.Move(move * speed * Time.deltaTime); //deltaTime, makes the time framerate independent, so that movementspeed is not dependent on how good framerate the pc runs.
        //This would result in the player moving at normal speed if the game was programmed on a low-end pc but if played on a high-end pc the player would move super fast.

         velocity.y += gravity * Time.deltaTime; //Unlocks the gravity modifier from the framerate.

        controller.Move(velocity * Time.deltaTime); //Applies velocity.y to the player.
    }
}