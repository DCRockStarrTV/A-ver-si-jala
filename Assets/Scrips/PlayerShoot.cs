using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletspeed;
    [SerializeField] private Transform gun;
    [SerializeField] private float CDown;
    private bool fireContinuosly;
    private float lastFireTime;
   
    void Update()
    {
        if (fireContinuosly)
        {
            float timeSinceLastFire = Time.time - lastFireTime;
            if (timeSinceLastFire >= CDown)
            {
                FireBullet();
                lastFireTime = Time.time;
            }
            
        }
    }

    private void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, gun.position, transform.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();

        rigidbody.velocity = bulletspeed * transform.up;
    }

    private void Onfire(InputValue inputValue)
    {
        fireContinuosly = inputValue.isPressed;
    }
}
