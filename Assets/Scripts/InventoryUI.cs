using UnityEngine;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public List<GameObject> UIbuttons;
    public InventoryManager InvUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RefreshInventory()
    {

        Debug.Log("Inventory UI updated");
        foreach (GameObject button in UIbuttons)
        {
            button.SetActive(false);
        }
        for (int i = 0; i < InvUI.inventory.Count; i++)
        {
            if(i < UIbuttons.Count)
            {
                UIButton localInventoryUIbutton;
                localInventoryUIbutton = UIbuttons[i].GetComponent<UIButton>();
                localInventoryUIbutton.SetButtonText(InvUI.inventory[i]);
                localInventoryUIbutton.gameObject.SetActive(true);

            }
            
        }
    }
    private void OnEnable()
    {
        RefreshInventory();
    }
}
    

