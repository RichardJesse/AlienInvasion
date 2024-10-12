using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    void Start()
    {
        Debug.Log("The script is running");
        SceneManager.LoadScene("Demo_Scene_A", LoadSceneMode.Additive);
    }
}
