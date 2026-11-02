using UnityEngine;
using UnityEngine.InputSystem;

public class Playercharactercontroller : StarterAssets.ThirdPersonController
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

    void OnRemoveItem(InputValue value)
    { 
        if(value.isPressed)
        {
            Debug.Log("Remove item button pressed");
            FindAnyObjectByType<InventoryManager>().Removeitemfrominventory();
        }
    }
}
