using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameTutorial : MonoBehaviour
{
    public GameObject text;
    public TextMeshProUGUI textAppear; 
    public string textString;

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
        if(other.gameObject.tag == "character")
        {
            text.SetActive(false);
        }

    void OnTriggerExit()
        {
            text.SetActive(false);
        }
    }
}
