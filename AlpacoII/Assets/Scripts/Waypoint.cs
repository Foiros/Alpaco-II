using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Waypoint : MonoBehaviour
{
    public float newCameraPosition, newPlayerPosition;

    public List<Sprite> perfectGraphics, shittyGraphics;
    public List<SpriteRenderer> renderers;

    private CameraController _cameraController;
    private PlayerMovement _playerMovement;
    private GameObject player;

    private void Awake()
    {
        _cameraController = GameObject.FindGameObjectWithTag("GameController").GetComponent<CameraController>();
        player = GameObject.FindGameObjectWithTag("Player");
        _playerMovement = player.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _cameraController.ChangeMyPosition(newCameraPosition);
            _playerMovement.SetIsMovingState(false);
            player.transform.position = new Vector3(player.transform.position.x + newPlayerPosition, player.transform.position.y, player.transform.position.y);
            
            ChangeGraphics();
        }
    }

    private void ChangeGraphics()
    {
        int randomNumber = Random.Range(0, 1);

        switch (randomNumber)
        {
            case 0:
                for (int i = 0; i < renderers.Count; i++)
                {
                    renderers[i].sprite = perfectGraphics[i];
                }
                break;
            
            case 1:
                for (int i = 0; i < renderers.Count; i++)
                {
                    renderers[i].sprite = shittyGraphics[i];
                }
                break;
        }
    }
}
