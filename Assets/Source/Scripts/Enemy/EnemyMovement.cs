using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float direction = _speed * Time.deltaTime;
        transform.Translate(Vector2.down * direction);
    }
}