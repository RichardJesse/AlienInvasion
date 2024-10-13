using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{

    public PlayerControls playerControls;
    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.wholeNumbers = true;
        healthBar.minValue = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
