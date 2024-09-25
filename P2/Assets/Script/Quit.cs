using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Press P;
    void Start()
    {
        P = FindAnyObjectByType<Press>();
        Debug.Log(P.CashItem);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(P.CashItem >= 1)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
