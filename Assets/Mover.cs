using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
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
    }
}
