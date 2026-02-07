using TMPro;
using UnityEngine;

public class ScoreScripits : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    public TextMeshProUGUI ScoreText;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sawit"))
        {
            score ++;
            ScoreText.text = "Score : " + score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
