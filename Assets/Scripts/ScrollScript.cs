using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour {

    public float scrollSpeed = 1f;
    public float scrollOffset = 0f;
    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * -scrollSpeed, scrollOffset);
        transform.position = startPosition + (Vector2.right * newPosition);
    }
}
