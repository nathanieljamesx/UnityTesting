using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public inputManager inputManager;

    public GameObject cameraPin;
    public GameObject orientationPin;
    public Rigidbody playerRBody;
    public PlayerState currentPlayerState = PlayerState.in_Character;
    private float defaultCharacterMoveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        ManagePlayerControl();
    }

    // Update is called once per frame
    void Update()
    {
        ManagePlayerControl();
    }

    void ManagePlayerControl()
    {
        //if(currentPlayerState == PlayerState.in_Character)
        //{
            ManageCameraRotation();
            ManageInCharacterMovement();
        //}

        ResolveCameraRotation();
        ResolveCameraPosition();
    }

    private Vector3 currentCameraRot = Vector3.zero;
    private float cameraRotSpeed = 7f;

    void ManageCameraRotation()
    {
        if(inputManager.cameraRotLeftDown)
        {
            currentCameraRot.y -= 90f;
        }

        if (inputManager.cameraRotRightDown)
        {
            currentCameraRot.y += 90f;
        }
    }

    void ResolveCameraRotation()

    {
        orientationPin.transform.localRotation = 
            Quaternion.LerpUnclamped(orientationPin.transform.localRotation,
            Quaternion.Euler(currentCameraRot),
            Time.smoothDeltaTime * cameraRotSpeed);
    }

    private float cameraFollowSpeed = 7f;

    void ResolveCameraPosition()
    {
        cameraPin.transform.position = Vector3.LerpUnclamped(cameraPin.transform.position,
            playerRBody.position,
            Time.smoothDeltaTime * cameraFollowSpeed);
    }

    void ManageInCharacterMovement()
    {
        Vector3 inputDir = Vector3.zero;

        if (inputManager.moveUp)
        {
            inputDir += orientationPin.transform.forward * defaultCharacterMoveSpeed;
        }

        if (inputManager.moveDown)
        {
            inputDir -= orientationPin.transform.forward * defaultCharacterMoveSpeed;
        }

        if (inputManager.moveLeft)
        {
            inputDir -= orientationPin.transform.right * defaultCharacterMoveSpeed;
        }

        if (inputManager.moveRight)
        {
            inputDir += orientationPin.transform.right * defaultCharacterMoveSpeed;
        }

        playerRBody.AddForce(inputDir * Time.smoothDeltaTime, ForceMode.VelocityChange);
    }
}

public enum PlayerState
{
    in_Character,
    in_Menu
}
