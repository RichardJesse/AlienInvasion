using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform alien;
    [SerializeField] private Transform Spaceship;


   
    public float spawncooldown = 5f;
    public float minSpawnDistance = 5f; 
    public float maxSpawnDistance = 10f;
    public float lastspawntime;

    void Start()
    {
        lastspawntime = Time.time;  
    }

    // Update is called once per frame
    void Update()
    {
        spawnalien();
    }

    void spawnalien()
    {
        if (Time.time - lastspawntime >= spawncooldown)
        {
            if (Spaceship != null && alien != null)
            {
                //Random Direction and  Distance
                float spawnDistance = Random.Range(minSpawnDistance, maxSpawnDistance);
                

               
                Vector3 spawnposition = Spaceship.position + Spaceship.forward * spawnDistance;

                //Instantiate the alien
                Transform spawnedAlien = Instantiate(alien,spawnposition,Quaternion.identity);

                // Make the alien face the player
                Vector3 directionTospaceship = Spaceship.position - spawnposition;
                directionTospaceship.y = 0;
                Quaternion lookRotation = Quaternion.LookRotation(directionTospaceship); 
                spawnedAlien.rotation = lookRotation; 


                //update the last spawn time
                lastspawntime = Time.time;
            }
        }
    }
}
