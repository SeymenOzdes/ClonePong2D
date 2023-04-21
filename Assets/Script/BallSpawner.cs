using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    
    public GameObject ball;
    
    void Start()
    {
        Instantiate(ball, new Vector2(0, 0), ball.transform.rotation);
    }

    void Update()
    {
        
    }

}
