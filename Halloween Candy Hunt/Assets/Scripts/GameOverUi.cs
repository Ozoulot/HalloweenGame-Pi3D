using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUi : MonoBehaviour
{
    public GameObject player; //Reference to the player object in the Unity hierarchy.
    public Canvas gameOver; //Reference to the Canvas with the gameover UI in the Unity hierarchy.
    public void Exit() //Function called when the player presses the "YES" button on the gameover UI.
    {
           if (UnityEditor.EditorApplication.isPlaying == true) //If statement that checks if the editor applicaiton (game) is playing, if yes then..
            {
                UnityEditor.EditorApplication.isPlaying = false; //Exit the editor application, which stops the game.
            }

           else //Used if the game is running as a build (not in the editor), checks if the applicaiton is runnning, if yes then..
             {
            Application.Quit(); //Stop the applicaiton and close the game.
            }
    }
    public void Continue() //Function called when the player presses the "NO" button on the gameover UI.
    {
        if (UnityEditor.EditorApplication.isPlaying == true) //Checks if the application is running, if yes then..
        {
           gameOver.enabled = false; //Disable the gameover UI.
            Cursor.lockState = CursorLockMode.Locked; //Locks the cursor to the middle of the screen again.
            Cursor.visible = false; //Makes the cursor invisible on the screen agian.
        }
    }
}
