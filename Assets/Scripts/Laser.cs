using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    GameObject Player;
    [SerializeField] private Transform smokeparticles;
    private float smokeLifetime = 3.0f;

    void OnCollisionEnter(Collision collision)
    {
        Player = GameObject.FindGameObjectWithTag("Player");
      
        
           

            if (collision.gameObject.CompareTag("Alien"))
            {

            ContactPoint contact = collision.contacts[0];

            // Instantiate the whole smoke prefab at the collision point
            Instantiate(smokeparticles, contact.point, Quaternion.identity);
            Destroy(collision.gameObject);
            Debug.Log("damage Alien");
            Destroy(this.gameObject);
            Destroy(smokeparticles,smokeLifetime);


              

                
            }
        else
        {
            Debug.Log("No Alien Object.");
            

        }



    }
    }

