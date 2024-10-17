using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTitle : MonoBehaviour
{
    public Button startButton;
    public Image gameTitle;
    //public AudioSource spaceShipSound;


    void Start()
    {
        Time.timeScale = 0; // Game is paused initially
        //spaceShipSound.loop = true;  // Loop the sound

        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        Time.timeScale = 1; // Resume game
        //spaceShipSound.Play();  // Play the sound
        gameTitle.gameObject.SetActive(false); // Hide game title
        startButton.gameObject.SetActive(false); // Hide start button
    }
}
