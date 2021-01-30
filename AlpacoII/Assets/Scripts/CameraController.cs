using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera mainCamera;
    private void Awake() { mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); }

    public void ChangeMyPosition(Vector3 newPosition) { mainCamera.transform.position = newPosition; }
}
