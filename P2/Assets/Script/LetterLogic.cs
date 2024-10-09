using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterLogic : MonoBehaviour
{
    public GameObject CurrentLetter;
    public GameObject NextLetter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            NextLetter.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
