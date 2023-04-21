using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D playerRb;
    public float moveSpeed = 13;

   
    void LateUpdate()
    {
        
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        player.transform.position = Vector2.MoveTowards(player.transform.position, mousePosition, moveSpeed * Time.deltaTime);

        // player'ın scene dışına çıkmasını engelliyoruz.
        if (player.transform.position.y > 3.35f)
        {
            player.transform.position = new Vector2(player.transform.position.x, 3.35f);
        }
        else if (player.transform.position.y < -3.35f)
        {
            player.transform.position = new Vector2(player.transform.position.x, -3.35f);
        }
        
    }
}
