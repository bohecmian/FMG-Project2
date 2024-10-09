using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    //I recommend you watch the full tutorial to know how this script works :)

    //The UI version of the letter that appears after picking up the letter.
    public GameObject LetterUI;


    bool toggle;
    int LE = 0;

    public FirstPersonController player;

    //The Mesh Renderer component of your letter that disables after picking up the letter and enables when putting it back down.
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
            LE = 1;
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
