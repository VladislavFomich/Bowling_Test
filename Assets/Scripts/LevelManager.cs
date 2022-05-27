using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void Update()
    {
        if (BallPool.Instance.ActiveBall == 0)
        {
            RestartScene();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        RestartScene();
    }
    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
