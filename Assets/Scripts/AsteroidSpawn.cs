using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public Asteroid prefabAsteroid;
    public int asteroidQuantity = 3;
    void Start()
    {
        for(int i = 0; i < asteroidQuantity; i++)
        {
            float x = Random.Range(-7.0f, 7.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Vector3 position = new Vector3(x, y, 0.0f);
            Instantiate(prefabAsteroid, position, Quaternion.identity);
        }
    }
}
