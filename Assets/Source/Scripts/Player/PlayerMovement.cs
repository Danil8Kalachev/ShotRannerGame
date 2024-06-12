using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    [SerializeField] private float _speed;

    private void Update()
    {
        TryMoveHorizontal();
        TryMoveVertical();
    }

    private void TryMoveHorizontal()
    {
        float horizontal = Input.GetAxis(Horizontal);
        float directionHorizontal = horizontal * _speed * Time.deltaTime;
        transform.Translate(Vector2.right * directionHorizontal);
    }

    private void TryMoveVertical()
    {
        float vertical = Input.GetAxis(Vertical);
        float directionVertical = vertical * _speed * Time.deltaTime;
        transform.Translate(Vector2.up * directionVertical);
    }
}