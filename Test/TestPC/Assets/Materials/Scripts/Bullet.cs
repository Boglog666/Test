using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Bullet : MonoBehaviour
{
    public Vector3 hitPoint;
    public int speed;
    void Start()
    {
        Physics.IgnoreLayerCollision(3, 7);
        Physics.IgnoreLayerCollision(3, 4);
        this.GetComponent<Rigidbody>().AddForce((hitPoint - this.transform.position).normalized * speed);
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<Health>().currentHealth -= 20;
            Destroy(this.gameObject);
        }
        else if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        Destroy(this.gameObject);
    }
}