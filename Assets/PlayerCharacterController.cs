using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterController : StarterAssets.ThirdPersonController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnPause(InputValue value)
    {
        if(value.isPressed)
        {
            Debug.Log("Pause button pressed");
            FindObjectOfType<GameManger>().OnPause();
        }
    }
}
