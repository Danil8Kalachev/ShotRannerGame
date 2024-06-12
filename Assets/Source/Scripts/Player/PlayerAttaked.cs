using UnityEngine;
using UnityEngine.Events;

public class PlayerAttaked : MonoBehaviour
{
    [SerializeField] private int _damage;

    public UnityEvent AttakedDamage;

    private void OnValidate() => _damage = Mathf.Clamp(_damage, 1, 1);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy) && _damage != 0)
        {
            enemy.ApplyDamage(_damage);
            AttakedDamage?.Invoke();
        }      
    }
}