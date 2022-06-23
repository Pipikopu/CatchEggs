using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    public Text finalScoreText;
    Health health;
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("Ground").GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        finalScoreText.text = "Final Score: " + score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Egg":
                score += 1;
                break;
            case "Bomb":
                health.TakeDamage();
                break;
            default:
                break;
        }

        Destroy(collision.gameObject);
    }
}
