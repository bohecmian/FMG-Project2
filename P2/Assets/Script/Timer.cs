using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    float countdown = 10;

    public TMP_Text tex;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown>0)
        {
            countdown -= Time.deltaTime;
        }
        double b = System.Math.Round(countdown, 1);
        tex.text = b.ToString();
        if (countdown <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
