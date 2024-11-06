using UnityEngine;

public class CannonballController : MonoBehaviour
{
    public float lifespan;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //After lifespan seconds, this object will be destroyed
        Destroy(gameObject, lifespan);
    }


    private void FixedUpdate()
    {
        rb.AddForce(transform.right *  5.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.collider.gameObject);
        Destroy(gameObject);
    }


}
