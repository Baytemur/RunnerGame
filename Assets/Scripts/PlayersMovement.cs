using UnityEngine;
using UnityEngine.SceneManagement;
public class playersMovement : MonoBehaviour
{
    bool alive = true;
    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultipler = 2;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultipler;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            Die();
        }
    }
    public void Die()
    {
        alive = false;
        // oyunu yeniden başlat
        Invoke("Restart", 2);
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
