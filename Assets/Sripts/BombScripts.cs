using UnityEngine;

public class BombScripts : MonoBehaviour
{
    public float fallSpeed = 1.5f;
    public int threshold = -6;
    public LogicScripts Logic;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
        if (transform.position.y < threshold)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Bomb meledak! Game Over.");
            Logic.GameOver();
        }
    }
}
