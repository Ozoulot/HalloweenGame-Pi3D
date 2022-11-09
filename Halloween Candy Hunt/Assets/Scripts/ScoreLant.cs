using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreLant : MonoBehaviour
{
	public static ScoreLant instance; //Creates an instance for another script to call and start.
	public TextMeshProUGUI lanternText; //Creates a TMProGUI for the lantern score text in the clipboard UI.

	int lanternScore = 0; //Sets the lantern score to 0.

	private void Awake() //Awake runs when the script is called.
	{
		instance = this; //Start of the instance called from another script.
	}

	void Start() //Start is called before the first frame update.
	{
		lanternText.text = lanternScore.ToString() + "/8"; //Sets the initial text on the clipboard to say "/8" as in "out of 8 lanterns to light".
	}

	public void AddCount() //AddCount() Is called when the player lights up a lantern, by colliding the lighter with the pumpkin.
	{
		lanternScore += 1; //Adds one to the lantern score.
		lanternText.text = lanternScore.ToString() + "/8"; //Gets the new score and prints it onto the clipboard UI as a string.
	}
}
