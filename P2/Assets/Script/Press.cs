using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class Press : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CollectText;
    public GameObject Cash;

    public int CashItem = 0;

    public TextMeshProUGUI itemText;
    void Start()
    {
        Cash.SetActive(true);
        CollectText.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                Destroy(Cash);
                CollectText.SetActive(false);
                CashItem++;
                itemText.text = "Cash: " + CashItem.ToString();
                Debug.Log(CashItem);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CollectText.SetActive(false);
    }



}
