using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Rigidbody2D asteroid;
    public float maxSpeed = 1.0f;
    void Start()
    {
        Vector2 direction = Random.insideUnitCircle;
        direction *= maxSpeed;
        asteroid.velocity = direction;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);
    }
}
