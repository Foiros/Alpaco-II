using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera mainCamera;

    private float myPosition;

    private void Awake() { mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>(); }

    private void Update() { myPosition = mainCamera.transform.position.x; }

    public void ChangeMyPosition(float newPosition)
    {
        mainCamera.transform.position = new Vector3(myPosition + newPosition, mainCamera.transform.position.y, mainCamera.transform.position.z);
    }
}
