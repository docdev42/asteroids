using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public float aceleration = 1.0f;
    public float angularSpeed = 180.0f;
    public float maxSpeed = 10.0f;

    public Rigidbody2D bulletPrefab;
    public float bulletSpeed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D bullet = Instantiate(
                bulletPrefab,
                playerRigidbody.position,
                Quaternion.identity
            );

            bullet.velocity = transform.up * bulletSpeed;
        }
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direction = transform.up * aceleration;
            playerRigidbody.AddForce(direction, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.rotation += angularSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.rotation -= angularSpeed * Time.deltaTime;
        }

        if(playerRigidbody.velocity.magnitude > maxSpeed)
        {
            playerRigidbody.velocity = Vector2.ClampMagnitude(
                playerRigidbody.velocity,
                maxSpeed
            );
        }
    }

    void OnTriggerEnter2D(Collider2D asteroid)
    {
        Destroy(gameObject);
    }
}
