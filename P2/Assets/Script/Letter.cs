using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    public GameObject LetterUI;
    public GameObject CurrentLetter;

    bool toggle;

    public FirstPersonController player;

    public Renderer letterMesh;

    //Function to open and close the letter.
    public void openCloseLetter()
    {
        //Toggle will equal to the opposite of what it currently equals to.
        toggle = !toggle;

        //If toggle equals false, that means the player is putting down the letter.
        if (toggle == false)
        {
            LetterUI.SetActive(false);
            letterMesh.enabled = true;
            player.enabled = true;
            Destroy(CurrentLetter);
        }
        //If toggle equals true, that means the player is picking up the letter.
        if (toggle == true)
        {
            LetterUI.SetActive(true);
            letterMesh.enabled = false;
            player.enabled = false;
        }
    }
}
