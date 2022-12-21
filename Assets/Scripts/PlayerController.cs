using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float speed = 7000f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // AddForce(float x, float y, float z)
        if (Input.GetKeyDown(KeyCode.W))
            player.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.S))
            player.AddForce(0, 0, -speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
            player.AddForce(-speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.D))
            player.AddForce(speed * Time.deltaTime, 0, 0);
    }
}
