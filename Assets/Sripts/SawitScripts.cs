using UnityEngine;

public class SawitScripts : MonoBehaviour
{
    public float fallSpeed = 1.5f;
    public LogicScripts Logic;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScripts>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Land"))
        {
            Debug.Log("Sawit jatuh ke tanah! Game Over.");
            Logic.GameOver();
        }
    }
}
