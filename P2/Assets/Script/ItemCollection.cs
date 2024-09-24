using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollection : MonoBehaviour
{
    // Start is called before the first frame update

    private int item = 0;

    public TextMeshProUGUI itemText;


    private void OnTriggerEnter(Collider other)
    {
        item++;
        itemText.text = "Item: " + item.ToString();
        Debug.Log(item);
        Destroy(other.gameObject);
    }

    
}
