using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    public bool cubeAppear = true;
    public void buttonPress()
    {
        EventBus.Current.CubeTrigger();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // If they press a button && they are in the trigger area
            // Do something specific (like pull a lever or something)
    }
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "character")
        {
             if(Input.GetKeyDown("e"))
        {
            Debug.Log("E button pressed");
            EventBus.Current.CubeTrigger();
        }
        }
        
    }
    void CubeActivate()
    {
    gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
    gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
    }
}