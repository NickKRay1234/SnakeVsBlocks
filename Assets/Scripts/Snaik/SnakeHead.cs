using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class SnakeHead : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public event UnityAction BlockCollided;
    public event UnityAction<int> BonusCollected;

    private void Start()
    {
        // Fetch the Rigidbody from the GameObject with this script attached
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 newPosition) // Apply the movement vector to the current position.
    {
        _rigidbody2D.MovePosition(newPosition);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        BlockCollided?.Invoke();

        if (collision.gameObject.TryGetComponent(out Block block))
            block.Fill();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Bonus bonus))
            BonusCollected?.Invoke(bonus.Collect());
    }



}
