using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Vincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int healh = 3;

    public Animator camAnim;
    public Text HP;
    public GameObject Gameover;



   

    // Update is called once per frame
    private void Update()
    {

        HP.text = healh.ToString();
        if (healh <= 0)
        {
            Gameover.SetActive(true);
            Destroy(gameObject);

        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x, transform.position.y + Vincrement);
           
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x, transform.position.y - Vincrement);
           
        }
        
           
        
    }
}
