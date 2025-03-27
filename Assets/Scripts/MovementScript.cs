using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    private float lifetime = 3.0f;

    // Update is called once per frame
    public void Update()
    {
        lifetime -= Time.deltaTime;

        MoveGameObject();
        GameManager instance = ObjectPooler.DequeueObject<GameManager>("Turtle");
        
        if (lifetime < 0.0f)
        {
            ObjectPooler.EnqueueObject(this, "Turtle");
            instance.gameObject.SetActive(false);
        }
    }

    void MoveGameObject()
    {
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
    }
};
