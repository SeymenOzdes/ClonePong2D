using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody2D ballRb;
    public float speed = 10;
    public bool isBallDestoyed = false;
    public bool isScene = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (!isScene)
        {
            ballRb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
            if (ball.transform.position.x > 7.40 || ball.transform.position.x < -7.4)
            {
                Destroy(ball);
                Debug.Log("top yok oldu");
            }
        }
        
    }


    /*IEnumerator RestartGameCountDownRoutine()
    {
        yield return new WaitForSecondsRealtime(2);
        Instantiate(ball, new Vector2(0, 0), ball.transform.rotation);
        Debug.Log("Top yeniden oluşturuluyor");
    }
    */
}
