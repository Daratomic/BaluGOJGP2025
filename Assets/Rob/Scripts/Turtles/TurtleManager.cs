using UnityEngine;

public class TurtleManager : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    public CoinManager coinManager;

    [SerializeField] private int highReward = 10;
    [SerializeField] private int lowReward = 5;

    // Update is called once per frame
    public void Update()
    {
        MoveGameObject();  
    }

    void MoveGameObject()
    {
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("endPoint"))
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        int CoinsChance = Random.Range(1, 101);
        if (CoinsChance > 95)
        {
            coinManager.addCoins(highReward);
        }
        else
        {
            coinManager.addCoins(lowReward);
        }
    }
};
