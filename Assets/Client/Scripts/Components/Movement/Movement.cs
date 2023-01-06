﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using CustomInspectorGraph;
using UnityEngine.UIElements;

public class Movement
{
    private PositionMovement positionMovement;

    public Movement(Transform movable)
    {
        positionMovement = new(movable);
    }

    public void SetVelocity(float velocity, AnimationCurve curve = null)
    {
        positionMovement.SetVelocity(velocity, curve);
    }

    public void MovePosition(Vector3 direction, float deltaTime)
    {
        positionMovement.MovePosition(direction, deltaTime);
    }
}