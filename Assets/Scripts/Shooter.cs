﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletTempalte;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bulletTempalte, _shootPoint);
        }
    }
}
