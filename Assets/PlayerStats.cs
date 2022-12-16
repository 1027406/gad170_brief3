using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    public HpBar hpBar;
    private float hpValue = 100f;
    private float hpMax = 100f;
    public bool poisoned = false;

    // Start is called before the first frame update
    void Start()
    {
        hpBar.InitBar(hpMax);
    }

    // Update is called once per frame
    void Update()
    {
        
    if (poisoned == true)
        {
        takeDamage(0.5f);
        }
    
    if(hpValue <= 0f)
        {
            Debug.Log("Hey you, you're finally awake");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void takeDamage(float damage)
        {
        hpValue -= damage;
        hpBar.SetValue(hpValue);
        }
    
}
