using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoremaneger : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trap"))
        {
            score++;
            Debug.Log(score); 

        }
    }
}
