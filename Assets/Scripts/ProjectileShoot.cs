using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject playerProjectile;
    public float shootCooldown = 0.3f; 
    private float lastShootTime;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        //cooldown
        if (Time.time >= lastShootTime + shootCooldown)
        {
         
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Play shooting sound
                audioManager.playerShootingSound(audioManager.playerShooting);

                // Spawn projectile
                Instantiate(playerProjectile, transform.position, Quaternion.identity);

                // Update the last shoot time
                lastShootTime = Time.time;
            }
        }
    }
}
