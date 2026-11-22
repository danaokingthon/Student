using UnityEngine;

public class StunEnemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerPhysics player = collision.gameObject.GetComponent<PlayerPhysics>();

        if (player != null)
        {
            player.Stun();
        }
    }
}