using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float health = 100f;
    public float maxHealth = 100f;
    public healthbar healthBar;
    public void Update()
    {
     healthBar.fillAmount = health / maxHealth;
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(10f);
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health < 0f)
        {
            health = 0f;
        }
    }
}
