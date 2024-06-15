using UnityEngine;

public class Coin : MonoBehaviour
{
    private int _count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            gameObject.SetActive(false);
            _count++;
        }
    }
}