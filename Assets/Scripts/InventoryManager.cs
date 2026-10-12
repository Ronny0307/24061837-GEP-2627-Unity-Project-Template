using UnityEngine;
using System.Collections.Generic;
public class InventoryManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<InventoryItem> inventory = new List<InventoryItem>();
    public GameManger gameManager;
    [SerializeField]private int maxinventorysize = 10;

    private InventoryItem Test_item = new InventoryItem("test item", 1, 0);

    public class InventoryItem
    {
        public string itemname;
        public int itemquantity;
        public int ownitemtag;
        public InventoryItem(string name, int quantity, int itemtag)
        {
            itemname = name;
            itemquantity = quantity;
            ownitemtag = itemtag;
        }
    }
    

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.stateid==0)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Additemtoinventory(Test_item);
                Debug.Log("Added item to inventory: " + Test_item.itemname);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                Removeitemfrominventory(Test_item);
                Debug.Log("Removed item from inventory: " + Test_item.itemname);
            }
        }

    }
       

    public void Additemtoinventory(InventoryItem item)
    {
        inventory.Add(item);
    }

    public void Removeitemfrominventory(InventoryItem item)
    {
        inventory.Remove(item);
    }
}
