using UnityEngine;

public class EnemyAttaked : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnValidate() => _damage = Mathf.Clamp(_damage, 1, 1);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player) && _damage != 0)
            player.ApplyDamage(_damage);
    }
}