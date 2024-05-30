using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MooveDrone : MonoBehaviour
{
    [SerializeField]
    private InputActionReference movement, movementTop;

    public RCEasyMoveControllerLerpMono m_drone;

    public Vector2 movementPlayer, movementTopPlayer;

    void Update()
    {
        movement.action.Enable();
        movementTop.action.Enable();

        movementPlayer = movement.action.ReadValue<Vector2>();
        movementTopPlayer = movementTop.action.ReadValue<Vector2>();

        m_drone.SetFrontalMove(movementPlayer.x);
        m_drone.SetHorizontaMove(movementPlayer.y);

        m_drone.SetHorizontalRotation(movementTopPlayer.x);
        m_drone.SetVerticalMove(movementTopPlayer.y);

        Debug.Log(movementPlayer);
    }
}
