using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    public float timeLeft = 5f;
    Text ShowTime;
    Canvas Winnn;

    // Start is called before the first frame update
    void Start()
    {
        ShowTime = GameObject.Find("/runtime/Text_ShowTime").GetComponent<Text>();
      
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            ShowTime.text = timeLeft.ToString("##0");
        }
        else
        {
            SceneManager.LoadScene("Win");
        }
       
        
    }
}
