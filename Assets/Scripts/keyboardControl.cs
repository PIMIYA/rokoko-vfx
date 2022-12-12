using UnityEngine;

public class keyboardControl : MonoBehaviour
{    
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(xDir, 0.0f, zDir);

        //  transform.position += moveDir * speed;          
        transform.position = Vector3.Lerp(transform.position, transform.position+moveDir, speed);
    }
}
