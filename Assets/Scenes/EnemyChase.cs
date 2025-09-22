using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;   // Drag the Player object here in Inspector
    public float speed = 3f;   // Enemy speed

    void Update()
    {
        if (player != null)
        {
            // Move enemy towards player
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );
        }
    }
}

