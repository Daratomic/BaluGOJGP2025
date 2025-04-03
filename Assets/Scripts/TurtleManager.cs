using UnityEngine;

public class TurtleManager : MonoBehaviour
{
    [SerializeField] float movementSpeed;

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
};
