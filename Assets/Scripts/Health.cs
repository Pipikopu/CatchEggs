using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int fullHealth;
    private int health;
    public Text healthText;
    public GameObject gameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        health = fullHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Egg")
        {
            TakeDamage();
        }
        Destroy(collision.gameObject);
    }

    public void TakeDamage()
    {
        health -= 1;
        if (health == 0)
        {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
