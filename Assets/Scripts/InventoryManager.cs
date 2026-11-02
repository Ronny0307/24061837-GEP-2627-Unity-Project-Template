using UnityEngine;
using System.Collections.Generic;
public class InventoryManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<InventoryItem> inventory = new List<InventoryItem>();
    public GameManager gameManager;
    [SerializeField]private int maxinventorysize = 10;

    public Transform Item;

    //private InventoryItem Test_item = new InventoryItem("test item", 1, 0);
    

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    { /*
        if(gameManager.stateid==0)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Additemtoinventory(Test_item);
                Debug.Log("Added item to inventory: " + Test_item.itemname);
            }/*
            if (Input.GetKeyDown(KeyCode.O))
            {
                Removeitemfrominventory(Test_item);
                Debug.Log("Removed item from inventory: " + Test_item.itemname);
            }
        }
        */  
    }
       
    public void AddItem(InventoryItem item)
    {
        inventory.Add(item);
    }
    public void RemoveItem(InventoryItem item)
    {
        inventory.Remove(item);
    }
    /*
    public void Additemtoinventory(InventoryItem item)
    {
        inventory.Add(item);
    }
    */
    public void Removeitemfrominventory(InventoryItem item)
    {
        if(inventory.Count>0)
        {
            InventoryItem Item = inventory[0];
            GameObject itemObject= item.gameObject;

            inventory.Remove(Item);
            Vector3 position = GetComponent<Transform>().position + GetComponent<Transform>().forward + Vector3.up;
            Quaternion rotation = Quaternion.Euler(0, 180, 0) * GetComponent<Transform>().rotation;
            GameObject newItem = Instantiate(itemObject, position, rotation, this.transform);
            newItem.SetActive(true);

            Destroy(itemObject);
        }
       

    }

    public InventoryItem RetrieveItem()
    {
        return inventory[0];
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        InventoryItem item = hit.gameObject.GetComponent<InventoryItem>();
        if(item!=null)
        {

            
            if(item.itemquantity>0)
            {
                while (item.itemquantity > 0)
                {
                    inventory.Add(item);
                    item.itemquantity--;
                }
                   
            }
            
            Debug.Log("Added item to inventory: " + item.itemname);
           
            item.OnCollect();
        }
    }
}
