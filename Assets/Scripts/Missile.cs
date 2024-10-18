using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    GameObject Player;
    

    void OnCollisionEnter(Collision collision)
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (Player == null)
        {
            Debug.Log("empty");
        }
        else
        {
            //Debug.Log("POLE");

            if (collision.gameObject.CompareTag("Spaceship"))
            {
                PlayerControls playerControls = Player.GetComponent<PlayerControls>();
                if (playerControls != null)
                {
                    // Call the Damage method to apply damage
                   
                    playerControls.Damage(10);
                   

                }

                else
                {
                    Debug.LogError("PlayerControls component is not found on the Player GameObject.");
                }
            }



        }
    }
}

