using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerInput _input;
    [SerializeField]
    private AgentMover _movement;

    private void Start()
    {
        _input.OnMouseClick += _movement.SetDestination;
    }
}