using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public EnemyShipData enemyShipData;

    Rigidbody rb;
    GameObject targetGameObject;
    Weapon weapon;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        weapon = GetComponent<Weapon>();
        targetGameObject = GameObject.FindGameObjectWithTag(enemyShipData.targetTag);
    }

    void Update()
    {
        Vector3 direciton = (targetGameObject.transform.position - transform.position);
        Vector3 cross = Vector3.Cross(transform.forward, direciton.normalized);

        float angle = (Vector3.Dot(direciton, transform.forward) > 0) ? cross.y : Mathf.Sign(cross.y);
        rb.AddTorque(Vector3.up * angle * enemyShipData.turnRate);

        rb.AddRelativeForce(Vector3.forward * enemyShipData.speed);

        if(direciton.magnitude < enemyShipData.fireRange)
        {
            weapon.Fire(transform.forward);
        }

        transform.position = Utilities.Wrap(transform.position, new Vector3(-45, -30, -30), new Vector3(45, 30, 30));
    }
}
