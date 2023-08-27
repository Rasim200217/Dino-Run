using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 private CharacterController _characterController;
 private Vector3 _direction;

 public float gravity = 9.81f * 2f;
 public float jumpForce = 8f;
 
 private void Awake()
 {
  _characterController = GetComponent<CharacterController>();
 }

 private void OnEnable()
 {
  _direction = Vector3.zero;
 }

 private void Update()
 {
  _direction += Vector3.down * gravity * Time.deltaTime;

  if (_characterController.isGrounded)
  {
   _direction = Vector3.down;

   if (Input.GetButton("Jump"))
   {
    _direction = Vector3.up * jumpForce;
   }
  }

  _characterController.Move(_direction * Time.deltaTime);
 }
}
