using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeInput : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    public Vector2 GetDirectionToClick(Vector2 headPosition)
    {
        Vector3 fingerPosition = Input.mousePosition;

        fingerPosition = _camera.ScreenToViewportPoint(fingerPosition);
        fingerPosition.y = 1;
        fingerPosition = _camera.ViewportToWorldPoint(fingerPosition);
        Vector2 direction = new Vector2(fingerPosition.x - headPosition.x, fingerPosition.y - headPosition.y);

        return direction;
    }



}
