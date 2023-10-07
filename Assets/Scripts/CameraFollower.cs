﻿using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public float Speed = 0.01f; // Speed of camera (Lerp)
    public Transform Camera; // Camera Object
    public Transform Player; // Player Object df

    private void Update()
    {
        var cameraPosition = Camera.position; // Get position of Camera
        cameraPosition.x = Mathf.Lerp(cameraPosition.x, Player.position.x, Speed); // Edit position
        Camera.position = cameraPosition; // Update Camera position
    }
}
