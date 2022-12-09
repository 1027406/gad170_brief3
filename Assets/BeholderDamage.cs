using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeholderDamage : MonoBehaviour
{

    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(wall);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Inside the zone");
        /*if (other.gameObject.name == "player") {
            other.gameObject.GetComponent<PlayerStats>().poisoned = true;
        }*/
    }

    private void OnTriggerLeave(Collider other)
    {
        /*
            if (other.gameObject.name == "player") {
                other.gameObject.GetComponent<PlayerStats>().poisoned = false;
            }
        */
    }
}
