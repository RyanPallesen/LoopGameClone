using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthComponent : MonoBehaviour
{
    public UnityEvent onHitEvent;
    public float health;
    public float maxHealth;
    public float healCooldown = 5;
    public float healPerSecond = 5;
    private float timer = 0;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        if(timer > healCooldown && health < maxHealth)
        {
            health += healPerSecond * Time.deltaTime;

            if (health > maxHealth)
                health = maxHealth;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
    public void OnHit()
    {
        timer = 0;

        onHitEvent.Invoke();
    }

    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }

    public void TakeDamage(float damage)
    {
        timer = 0;
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        DestroyThis();
    }
}
