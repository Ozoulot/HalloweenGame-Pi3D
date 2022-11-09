using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
	Light llight; //Reference to the spotlight component attached to the flashlight.
	void Start() //Start is called before the first frame update.
	{
		llight = GetComponent<Light>(); //Gets the spotlight component from flashlight
		llight.enabled = false; //Disables the spotlight when the game starts.
	}

	void Update() //Update is called once pr. frame.
	{
		if (Input.GetKeyUp(KeyCode.F)) //If statement that checks if the player is pressing F, if yes then..
		{
			gameObject.GetComponent<AudioSource>().Play(); //Play a flashlight click sound.
			llight.enabled = !llight.enabled; //Enable the spotlight attached to the flashlight.
		}	
    }
}