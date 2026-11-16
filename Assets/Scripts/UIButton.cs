using TMPro;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    public TMP_Text buttonText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetButtonText(InventoryItem inventoryItem)
    {
        buttonText.text = inventoryItem.name;

    }
}
