using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeholderDamage : MonoBehaviour
{

    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "character")
        {
            Debug.Log("Inside the zone");
            other.gameObject.GetComponent<PlayerStats>().poisoned = true;
        }
    }

    void OnTriggerLeave(Collider other)
    {
        
        if (other.gameObject.name == "character")
        {
            other.gameObject.GetComponent<PlayerStats>().poisoned = false;
        }
        
    }
}
