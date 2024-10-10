using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterPage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        HideCanvas();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject image;

    // Method to deactivate the Canvas
    public void HideCanvas()
    {
        if (image != null)
        {
            image.SetActive(false);  
        }
        else
        {
            Debug.LogWarning("Canvas reference is not set.");
        }
    }
}
