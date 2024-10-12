using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooter : MonoBehaviour
{

    public float coolDown = 0f;
    public float fireRate = 0f;


    public bool isFiring = false;

    public Transform FirePoint;
    public GameObject laser;
    public AudioSource fireSound;

    // Start is called before the first frame update
    void Start()
    {

        isFiring = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        checkInput();
        coolDown -= Time.deltaTime;

        if(isFiring == true)
        {
            Fire();
        }
    }

    void checkInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFiring = true;
        }
        else
        {
            isFiring = false;
        }

    }
    void Fire()
    {
        if(coolDown > 0)
        {
            return;
        }
         
        if(fireSound != null)
        {
            fireSound.Play();
        }

        GameObject.Instantiate(laser, FirePoint.position, FirePoint.rotation);

        coolDown = fireRate;
    }
}
