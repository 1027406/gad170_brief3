using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner5 : MonoBehaviour
{
    public GameObject gameObject;
    public bool cubeAppear = true;
    public void buttonPress()
    {
        EventBus.Current.CubeTrigger();
    }

    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.Cube += CubeSpawner5Appears;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CubeSpawner5Appears()
    {
        Debug.Log("This is what it feels like to spawn 3 cubes");
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    void OnDestroy()
    {
        EventBus.Current.Cube -= CubeSpawner5Appears;
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
    
}
