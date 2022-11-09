using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnonLant : MonoBehaviour
{
    public GameObject PumpkinGlow; //Reference to the Gameobject PumpkinGlow in the Unity hierarchy.
    public GameObject Pumpkin; //Reference to the Gameobject Pumpkin in the Unity hierarchy.

    public void TurnOn() //Will run if the lighter touches the pumpkins box collider.
    {
            gameObject.GetComponent<AudioSource>().Play(); //Plays a lighter click sound.
            PumpkinGlow.SetActive(true); //Activates the glowing pumpking gameobject.
            Pumpkin.SetActive(false); //Disables the pumpkin gameobject.

            ScoreLant.instance.AddCount(); //Calls and runs the function AddCount() from the ScoreLant script, which is attacked to the clipboard UI.

    }

}
