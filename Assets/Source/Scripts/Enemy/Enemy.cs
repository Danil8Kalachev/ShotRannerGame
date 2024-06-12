using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;

    private void OnValidate() => _health = Mathf.Clamp(_health, 1, 3);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnemyDestroed enemyDestroed))
            Die();
    }

    private void Die() => gameObject.SetActive(false);

    public void ApplyDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            gameObject.SetActive(false);
    }
}