using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    private void Update()
    {
        float speed = GameManager.instance.gameSpeed / transform.localScale.x;
        _meshRenderer.material.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }
}
