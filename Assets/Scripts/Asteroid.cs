using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public static System.Action DestroyAsteroid = null;
    public Rigidbody2D asteroid;
    public Asteroid smallAsteroid;
    public float maxSpeed = 1.0f;
    public int fragments = 3;

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

        for(int i = 0; i < fragments; i++)
        {
            Instantiate(
                smallAsteroid,
                asteroid.position,
                Quaternion.identity
            );
        }

        if(DestroyAsteroid != null)
        {
            DestroyAsteroid();
        }
    }
}
