﻿using System;
using UnityEngine;

namespace Content.Scripts
{
    public class GameController : MonoBehaviour
    {
        private Vector3 _direction = Vector3.right;
        private float _speed = 5f;
        
        void Start()
        {
            
        }

        private void Update()
        {
            var velocity = _direction * _speed;
            //this is the some test comment from rinat
            //there i removed some string
            velocity += 42;
            UnityEngine.Debug.Log($"Current Velocity: {velocity}");
            transform.position = transform.position + velocity * Time.deltaTime;
        }
    }
}
