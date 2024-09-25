using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class DoorScipt : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Press PP;
    public GameObject GoldDoor;
    public GameObject ArtDoor;
    public GameObject DoorEnter;
    void Start()
    {
        PP = FindAnyObjectByType<Press>();
        Debug.Log(PP.goldkey);
        DoorEnter.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            DoorEnter.SetActive(true);
            if(PP.goldkey >= 1)
            {
                Destroy(GoldDoor);
                DoorEnter.SetActive(false);
            }
            
        }
        else if (other.gameObject.tag == "Player")
        {
            DoorEnter.SetActive(true);
            if (PP.artKey >= 1)
            {
                Destroy(ArtDoor);
                DoorEnter.SetActive(false);
            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        DoorEnter.SetActive(false);
    }
}
