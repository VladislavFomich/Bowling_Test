using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody _rb;

    

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();  
    }
    private void Update()
    {
        _rb.velocity = Vector3.forward * speed;
    }
   
}
