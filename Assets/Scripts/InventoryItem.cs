using UnityEngine;

public class InventoryItem : MonoBehaviour
{

    public string itemname;
    public int itemquantity;
    public int ownitemtag;
    public string description;
    public int flags;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public virtual void OnCollect()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
