using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    public bool cubeAppear = true;
    public bool innerArea;


    // Start is called before the first frame update
    void Start()
    {
    EventBus.Current.Cube += CubeActivate;
    }

    // Update is called once per frame
    void Update()
    {
    if(innerArea)
    
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("E button pressed");
            EventBus.Current.CubeTrigger();
        }
        // If they press a button && they are in the trigger area
        // Do something specific (like pull a lever or something)
    }

    public void OnTriggerEnter(Collider collider)
    {
            if(collider.gameObject.name == "character")
            {
                innerArea = true;
            }
    }

    public void OnTriggerExit(Collider collider)
    {
            if (collider.gameObject.name == "character")
            {
                innerArea = false;
                print("is false");
            }
    }
        
    
    void CubeActivate()
    {
    gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
    gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
    }

    public void OnDestroy()
    {
        EventBus.Current.Cube -= CubeActivate;
    }
}
