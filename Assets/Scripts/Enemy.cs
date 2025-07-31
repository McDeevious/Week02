using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health = 5;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage()
    {
        if(health <= 0)
        {
            Debug.Log("Enemy is dead");
        }
        else
        {
            health--;
            spriteRenderer.color = Color.red;
        }
        Debug.Log("Current health: " + health);
    }

    public void Heal()
    {
        health++;
        spriteRenderer.color = Color.green;
        Debug.Log("Current health: " + health);
    }
}
