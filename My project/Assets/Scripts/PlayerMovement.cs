using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private int moveSpeed = 10;
    private PlayerActions movement;
    private InputAction direction;
    private Vector3 position;
    void Awake()
    {
        movement = new PlayerActions();
        direction = movement.PlayerMovement.Direction;
    }

    void OnEnable()
    {
        direction.Enable();
    }

    void OnDisable()
    {
        direction.Disable();
    }

    void FixedUpdate() //Player was not moving //Not reading input (fixed by adding control scheme)
    {
        position = direction.ReadValue<Vector2>();
        position.z = position.y;
        position.y = 0;
        
        transform.Translate(position * Time.deltaTime * moveSpeed, Space.Self);
    }
}
