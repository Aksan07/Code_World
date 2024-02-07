using UnityEngine;

public class Blue_car_movement : MonoBehaviour
{
    public Rigidbody2D rd;
    
    public float moveSpeed=5;
    public float deadZone=24;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        rd.velocity=Vector2.right*4;
        if(transform.position.x>deadZone){
            Destroy(gameObject);
        }
    }
}
