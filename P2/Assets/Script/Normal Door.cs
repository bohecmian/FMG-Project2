using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject HallDoor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(HallDoor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
