using UnityEngine;

public class PipeColliderScript : MonoBehaviour
{
    public LogicManagerScript logicManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicManager = FindFirstObjectByType<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {
            Debug.Log("Bird passed through pipe");
            logicManager.AddScore(1);
        }
    }
}
