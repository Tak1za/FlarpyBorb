using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength = 5;
    public LogicManagerScript logicManager;
    public float bottomDeadZone = -20;
    public float topDeadZone = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicManager = FindFirstObjectByType<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && logicManager.isBirdAlive)
        {
            // Move the bird up
            rb.linearVelocity = flapStrength * Vector2.up;
        }

        if (transform.position.y < bottomDeadZone || transform.position.y > topDeadZone)
        {
            Debug.Log("Bird out of bounds");
            Destroy(gameObject);
            logicManager.GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with " + collision.gameObject.name);
        if (collision.gameObject.layer == 3)
        {
            logicManager.GameOver();
        }
    }
}
