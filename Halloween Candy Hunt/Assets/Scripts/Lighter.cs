using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //Function that checks if the lighter collides with another collider in the scene.
    {
        if (other.gameObject.CompareTag("Lighter")) //If statement that checks if the lighter collides with another object with the tag "Lighter", if yes then..
        {
            other.gameObject.GetComponent<TurnonLant>().TurnOn(); //Calls the function TurnOn() from the TurnonLant script, to light up the lantern, and count 1 to the score.
        }
    }
}
