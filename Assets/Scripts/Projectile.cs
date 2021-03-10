using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [Range(1, 5)] public float timer = 1;
    [Range(1,100)]public float speed = 10.0f;
    public bool destroyOnHit;
    public GameObject destroyFx;

    private void Start()
    {
        Destroy(gameObject, timer);
    }

    private void OnDestroy()
    {
        if(destroyFx != null)
        {
            Instantiate(destroyFx, transform.position, transform.rotation);
        }
    }

    public void Fire(Vector3 forward)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(forward * speed, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(destroyOnHit)
        {
            Destroy(gameObject);
        }
    }

}
