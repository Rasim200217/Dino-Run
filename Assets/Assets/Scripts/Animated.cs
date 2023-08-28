using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animated : MonoBehaviour
{
   public Sprite[] Sprites;

   private SpriteRenderer _spriteRenderer;
   private int _frame;
   
   private void Awake()
   {
      _spriteRenderer = GetComponent<SpriteRenderer>();
   }

   private void OnEnable()
   {
      Invoke(nameof(Animate), 0f);
   }

   private void OnDisable()
   {
      CancelInvoke();
   }

   private void Animate()
   {
      _frame++;

      if (_frame >= Sprites.Length)
      {
         _frame = 0;
      }

      if (_frame >= 0 && _frame < Sprites.Length)
      {
         _spriteRenderer.sprite = Sprites[_frame];
      }
      
      Invoke(nameof(Animate), 1f / GameManager.instance.gameSpeed);
   }
}
