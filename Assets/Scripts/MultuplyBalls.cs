using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultuplyBalls : MonoBehaviour
{ 
     enum Sign { Plus, Minus, Divide, Multiply};
    [SerializeField] private Sign sign;
    [SerializeField] private int num;


    private void OnTriggerEnter(Collider other)
    {
        switch (sign)
        {
           case Sign.Plus:
                for (int i = 0; i < num; i++)
                {
                    BallPool.Instance.Instantiate(transform.position, Quaternion.identity);
                }
                break;

           case Sign.Minus:
                BallPool.Instance.DestroyBall(num);
                break;
            
           case Sign.Multiply:
                int multNum = (num - 1) * BallPool.Instance.ActiveBall;
                for (int i = 0;i < multNum; i++)
                {
                    BallPool.Instance.Instantiate(transform.position,Quaternion.identity);
                }
                break;
           case Sign.Divide:
                int num1 = BallPool.Instance.ActiveBall / num;;
                int divideNum = BallPool.Instance.ActiveBall - num1;
                BallPool.Instance.DestroyBall(divideNum);
                break;
        }
            
    }
}
