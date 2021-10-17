using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SnakeHead : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        // Fetch the Rigidbody from the GameObject with this script attached
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 newPosition) // Apply the movement vector to the current position.
    {
        _rigidbody2D.MovePosition(newPosition);
    }



}
