using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float maxXPos = 15f;
    [SerializeField] float minXPos = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    void Update()
    {
        float mouseXPosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mouseXPosInUnits, minXPos, maxXPos);
        transform.position = paddlePos;
    }
}
