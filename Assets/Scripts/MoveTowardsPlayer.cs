using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public Transform Player;
    public float movespeed = 5f;
    public float distanceThreshold = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            float distance = Vector3.Distance(Player.position, transform.position);



            if (distance < distanceThreshold && distance > 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.position, movespeed * Time.deltaTime);
            }
        }
    }
}
