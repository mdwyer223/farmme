using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
    public PlayerMovement moveScript;

    // movement
    protected float horizMove;
    protected float vertMove; 

    private void Update() {
        horizMove = Input.GetAxisRaw("Horizontal");
        vertMove = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        moveScript.Move(horizMove * Time.fixedDeltaTime, vertMove * Time.fixedDeltaTime);
    }
}