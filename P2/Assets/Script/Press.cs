using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CollectText;
    public GameObject Cash;
    void Start()
    {
        Cash.SetActive(true);
        CollectText.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                Destroy(Cash);
                CollectText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CollectText.SetActive(false);
    }



}
