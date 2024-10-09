using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter1 : MonoBehaviour
{
    public GameObject Letter;
    public GameObject NextLetter;
    // Start is called before the first frame update
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
