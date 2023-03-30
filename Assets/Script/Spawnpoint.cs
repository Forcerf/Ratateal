using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Trap;
    void Start()
    {
        Instantiate(Trap, transform.position, Quaternion.identity); 
    }

   
}
