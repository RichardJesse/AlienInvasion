using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alienshooter : MonoBehaviour
{
    [SerializeField] private Transform missile;

    [SerializeField] private Transform ShootingOrigin;

    public int minbulletcount = 1;
    public int maxbulletcount = 5;
    public float bulletSpread = 0.1f;
   

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShootatSpaceship(Transform Targetship)
    {
        int bulletCount = Random.Range(minbulletcount, maxbulletcount);
        if (missile != null && ShootingOrigin != null)
        {
            for (int i = 0; i < bulletCount; i++) {
                Transform missiletransform = Instantiate(missile, ShootingOrigin.position, Quaternion.identity);
                Rigidbody missileRigidbody = missiletransform.GetComponent<Rigidbody>();

                Vector3 shootingdirection = (Targetship.position - ShootingOrigin.position).normalized;

                if (missileRigidbody != null)
                {
                    missileRigidbody.velocity = shootingdirection * 30f;
                }

            }
        }
    }
}
