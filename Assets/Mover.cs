using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // ~~~~~~~~~~ For moving forward then back experimentation ~~~~~~~~~~
    // float zPositionTracker = 0f;
    // float zPositionLimiter = 10f;
    // float xPositionCrementer = 0f;
    // float yPositionCrementer = 0f;
    // float zPositionCrementer = 0.01f;
    // bool isRunningAway = true;
    // bool isRunning = true;
    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float unitsToMovePerSecond = 10;
        float xPositionCrementer = unitsToMovePerSecond * Input.GetAxis("Horizontal") * Time.deltaTime;
        float zPositionCrementer = unitsToMovePerSecond * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xPositionCrementer, 0, zPositionCrementer);
        // ~~~~~~~~~~~ Moving forward and back ~~~~~~~~~~~~~~~~~~~~~~~~~
        // if (isRunningAway) {
        //     zPositionCrementer = 0.01f;
        // }
        // else {
        //     zPositionCrementer = -0.01f;
        // }
        // zPositionTracker += zPositionCrementer;
        // Debug.Log("zPositionTracker: " + zPositionTracker);
        // Debug.Log("isRunningAway: " + isRunningAway);
        // if (zPositionTracker > zPositionLimiter) {
        //     isRunningAway = false;
        // }
        // else if (zPositionTracker < 0) {
        //     isRunning = false;
        // }
        // if (isRunning) {
        //     transform.Translate(xPositionCrementer, yPositionCrementer, zPositionCrementer);
        // }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
}
