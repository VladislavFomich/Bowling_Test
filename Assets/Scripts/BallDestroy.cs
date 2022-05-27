using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            BallPool.Instance.DecreaseBalls();
            gameObject.SetActive(false);
        }
    }
}
