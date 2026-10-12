using UnityEngine;
using System.Collections.Generic;
public class InventoryManageer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<string> inventory = new List<string>();
    public GameManger gameManager;
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
                Additemtoinventory("test item");
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                Removeitemfrominventory("test item");
            }
        }

    }
       

    public void Additemtoinventory(string itemname)
    {
        inventory.Add(itemname);
    }

    public void Removeitemfrominventory(string itemname)
    {
        inventory.Remove(itemname);
    }
}
