using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    // Read from config file at later date.
    public KeyCode moveUpKey = KeyCode.W;
    public KeyCode moveDownKey = KeyCode.S;
    public KeyCode moveLeftKey = KeyCode.A;
    public KeyCode moveRightKey = KeyCode.D;

    public KeyCode actionOneKey = KeyCode.J;
    public KeyCode actionTwoKey = KeyCode.K;
    public KeyCode actionThreeKey = KeyCode.L;
    public KeyCode actionFourKey = KeyCode.Semicolon;

    public KeyCode cameraRotLeftKey = KeyCode.LeftArrow;
    public KeyCode cameraRotRightKey = KeyCode.RightArrow;

    public KeyCode menuOneKey = KeyCode.Tab;
    public KeyCode menuTwoKey = KeyCode.Escape;

    public bool moveUp = false;
    public bool moveDown = false;
    public bool moveLeft = false;
    public bool moveRight = false;

    public bool actionOneDown = false;
    public bool actionTwoDown = false;
    public bool actionThreeDown = false;
    public bool actionFourDown = false;

    public bool cameraRotLeftDown = false;
    public bool cameraRotRightDown = false;

    public bool menuOneDown = false;
    public bool menuTwoDown = false;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateInputKeys()
    {
        moveUp = Input.GetKey(moveUpKey);
        moveDown = Input.GetKey(moveDownKey);
        moveLeft = Input.GetKey(moveLeftKey); 
        moveRight = Input.GetKey(moveRightKey);

        actionOneDown = Input.GetKeyDown(actionOneKey);
        actionTwoDown = Input.GetKeyDown(actionTwoKey);
        actionThreeDown = Input.GetKeyDown(actionThreeKey);
        actionFourDown = Input.GetKeyDown(actionFourKey);

        cameraRotLeftDown = Input.GetKeyDown(cameraRotLeftKey);
        cameraRotRightDown = Input.GetKeyDown(cameraRotRightKey);

        menuOneDown = Input.GetKeyDown(menuOneKey);
        menuTwoDown = Input.GetKeyDown(menuTwoKey);

    }
}
