using UnityEngine;
using UnityEngine.UI;

namespace TowerDefense
{
    public class Enemy : MonoBehaviour
    {
        [Header("Unity Stuff")]
        public Image healthBar;

        [HideInInspector]
        public float speed;

        public GameObject deathEffect;

        public float startSpeed = 10f;
        public float startHealth = 100;

        public int worth = 50;

        private bool isDead = false;

        private float health;

        // Use this for initialization
        void Start ()
        {
            speed = startSpeed;

            health = startHealth;
        }

        public void TakeDamage (float amount)
        {
            health -= amount;

            healthBar.fillAmount = health / startHealth;

            if (health <= 0 && !isDead)
            {
                Die();
            }
        }

        public void Slow (float pct)
        {
            speed = startSpeed * (1f - pct);
        }

        void Die ()
        {
            isDead = true;

            PlayerStats.Money += worth;

            GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);

            Destroy(effect, 5f);

            WaveSpawner.EnemiesAlive--;

            Destroy(gameObject);
        }
    }
}