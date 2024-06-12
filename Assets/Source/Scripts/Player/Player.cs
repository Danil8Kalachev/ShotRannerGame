using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private void OnValidate() => _health = Mathf.Clamp(_health, 1, 3);

    public void ApplyDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Destroy(gameObject);
    }
}