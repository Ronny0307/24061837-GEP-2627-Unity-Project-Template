using UnityEngine;

public class Collectibleball : InventoryItem
{
    public Transform Player;
    public Transform Ball;
    public float movespeed = 5f;
    public float distanceThreshold = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if(Player!=null && Ball!=null)
        {
            float distance = Vector3.Distance(Player.position, Ball.position);


           
            if (distance<distanceThreshold && distance>1)
            {
                transform.position = Vector3.MoveTowards(Ball.position, Player.position, movespeed * Time.deltaTime);
            }
        }
    }

    public override void OnCollect()
    {
        base.OnCollect();

    }
}
