using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class DoorScipt : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Press P;
    public GameObject GoldDoor;
    public GameObject DoorEnter;
    void Start()
    {
        P = FindAnyObjectByType<Press>();
        Debug.Log(P.goldkey);
        DoorEnter.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            DoorEnter.SetActive(true);
            Destroy(GoldDoor);
            DoorEnter.SetActive(false);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        DoorEnter.SetActive(false);
    }
}
