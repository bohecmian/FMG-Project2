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
    public GameObject Cash1;
    public GameObject Cash2;
    public GameObject Cash3;

    public GameObject Gold;
    public GameObject Gold1;
    public GameObject Gold2;

    public GameObject GoldKey;
    public bool goldkey = false;

    public int cash = 100;
    public int cash1 = 200;
    public int cash2 = 300;
    public int cash3 = 500;

    public int gold = 100;
    public int gold1 = 500;
    public int gold2 = 5000;


    public int CashItem = 0;
    public int GoldItem = 0;
    public int ArtIterm = 0;

    public TextMeshProUGUI itemText;
    public TextMeshProUGUI GlodText;
    public TextMeshProUGUI ArtText;
    void Start()
    {
        CollectText.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Cash")
        {

            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                CashItem++;
                cash--;
                if(cash <=0)
                {
                    Destroy(Cash);
                    CollectText.SetActive(false);
                }
                itemText.text = "Cash: " + CashItem.ToString();
                Debug.Log(CashItem);
            }
        }
        else if (other.gameObject.tag == "Cash1")
        {
            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                CashItem++;
                cash1--;
            
            if (cash1 <= 0)
            {
                Destroy(Cash1);
                CollectText.SetActive(false);
            }
            itemText.text = "Cash: " + CashItem.ToString();
            Debug.Log(CashItem);
            }
        }
        else if (other.gameObject.tag == "Cash2")
        {
            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                CashItem++;
                cash2--;

                if (cash2 <= 0)
                {
                    Destroy(Cash2);
                    CollectText.SetActive(false);
                }
                itemText.text = "Cash: " + CashItem.ToString();
                Debug.Log(CashItem);
            }
        }
        else if (other.gameObject.tag == "Cash3")
        {
            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                CashItem++;
                cash3--;

                if (cash3 <= 0)
                {
                    Destroy(Cash3);
                    CollectText.SetActive(false);
                }
                itemText.text = "Cash: " + CashItem.ToString();
                Debug.Log(CashItem);
            }
        }
        else if (other.gameObject.tag == "Gold")
        {
            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                GoldItem++;
                gold--;

                if (gold<= 0)
                {
                    Destroy(Gold);
                    CollectText.SetActive(false);
                }
                itemText.text = "Gold: " + GoldItem.ToString();
                Debug.Log(GoldItem);
            }
        }
        else if (other.gameObject.tag == "Gold1")
        {
            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                GoldItem++;
                gold1--;

                if (gold1 <= 0)
                {
                    Destroy(Gold1);
                    CollectText.SetActive(false);
                }
                itemText.text = "Gold: " + GoldItem.ToString();
                Debug.Log(GoldItem);
            }
        }
        else if (other.gameObject.tag == "Gold2")
        {
            CollectText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                GoldItem++;
                gold2--;

                if (gold2 <= 0)
                {
                    Destroy(Gold2);
                    CollectText.SetActive(false);
                }
                itemText.text = "Gold: " + GoldItem.ToString();
                Debug.Log(GoldItem);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CollectText.SetActive(false);
    }



}
