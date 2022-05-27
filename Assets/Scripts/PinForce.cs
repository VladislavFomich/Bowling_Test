using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinForce : MonoBehaviour
{
    [SerializeField] private float force;
    private Rigidbody _rb;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ball")
        {
         _rb.AddForce(new Vector3(1,5,2)* force);
        }
    }
}
