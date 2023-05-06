using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int dmg;
    [SerializeField] int speed;
    [SerializeField] int timer;

    [SerializeField] Rigidbody rb;

 
    void Start()
    {
        Destroy(gameObject, timer);
        rb.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        IDamage damageable = other.GetComponent<IDamage>();

        if (damageable != null)
        {
            damageable.takeDamage(dmg);
        }

        Destroy(gameObject);

    }

}
