using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float speed;
    private Touch tap;
    Rigidbody rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.touches.Length > 0)
        {
            tap = Input.touches[0];            
            if (tap.phase == TouchPhase.Moved)
            {
                Vector3 newPos = new Vector3(transform.position.x + tap.deltaPosition.x * Time.deltaTime * speed, transform.position.y, transform.position.z);
                transform.position = new Vector3(Mathf.Clamp(newPos.x, 44f, 57f),newPos.y, newPos.z); 
            }

        }
    }
}