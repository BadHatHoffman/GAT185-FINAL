using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate = 0.1f;
    public GameObject projectile;
    public Transform emitTransform;

    //int ammo = 100;
    float fireTimer = 0;

    void Update()
    {
        fireTimer += Time.deltaTime;
    }

    public bool Fire(Vector3 position, Vector3 direction)
    {
        if(fireTimer >= fireRate)
        {
            fireTimer = 0;
            GameObject gameObject = Instantiate(this.projectile, position, Quaternion.identity);
            gameObject.GetComponent<Projectile>().Fire(direction);

            return true;
        }

        return false;   
    }

    public bool Fire( Vector3 direction)
    {
        if (fireTimer >= fireRate)
        {
            fireTimer = 0;
            GameObject gameObject = Instantiate(this.projectile, emitTransform.position, emitTransform.rotation);
            gameObject.GetComponent<Projectile>().Fire(direction);

            return true;
        }

        return false;
    }
}
