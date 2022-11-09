using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
	public static Score instance; //Creates an instance for another script to call and start.
	public TextMeshProUGUI candyText; //Creates a TMProGUI for the lantern score text in the clipboard UI.

	int candyScore = 0; //Sets the candy score to 0.

	private void Awake() //Awake runs when the script is called.
	{
		instance = this; //Start of the instance called from another script.
	}

	void Start() //Start is called before the first frame update.
	{
		candyText.text = candyScore.ToString() + "/14"; //Sets the initial text on the clipboard to say "/14" as in "out of 14 candies to collect".
	}

	public void AddCount() //AddCount() Is called when the player picks up a piece of candy, by pressing E near it.
	{
		candyScore += 1; //Adds 1 to the candy score.
		candyText.text = candyScore.ToString() + "/14"; //Gets the new score and prints it onto the clipboard UI as a string.
}
}
