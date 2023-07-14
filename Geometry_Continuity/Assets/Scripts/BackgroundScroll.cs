using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 2f;

    private Renderer backgroundRenderer;
    private float backgroundSize;

    private Transform characterTransform;
    private Vector3 characterPreviousPosition;

    private void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();
        backgroundSize = backgroundRenderer.bounds.size.x;

        characterTransform = GameObject.FindGameObjectWithTag("Player").transform;
        characterPreviousPosition = characterTransform.position;
    }

    private void Update()
    {
        float characterMovementDelta = characterTransform.position.x - characterPreviousPosition.x;
        float backgroundOffset = characterMovementDelta * scrollSpeed;

        Vector2 textureOffset = new Vector2(backgroundOffset, 0);
        backgroundRenderer.material.mainTextureOffset += textureOffset;

        if (Mathf.Abs(backgroundRenderer.material.mainTextureOffset.x) >= backgroundSize)
        {
            backgroundRenderer.material.mainTextureOffset -= new Vector2(backgroundSize, 0);
        }

        characterPreviousPosition = characterTransform.position;
    }
}