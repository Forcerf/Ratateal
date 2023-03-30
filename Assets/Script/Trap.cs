using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour{

    public int damage = 1;
    public float speed;
    

    public GameObject effect;
    private Animator camAnim;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            camAnim.SetTrigger("shake");

            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<Player>().healh -= damage;
            Debug.Log(other.GetComponent<Player>().healh);
            Destroy(gameObject);
        }
    }
}
