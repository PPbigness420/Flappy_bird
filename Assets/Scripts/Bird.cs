

using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    //public
    public float JumpSpeed;
    public float RotatePower;

    //private
    Rigidbody2D rb;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * JumpSpeed;
        }
        //old method

        //if (rb.velocity.y > 0)
        //{
        //    transform.eulerAngles = new Vector3(0,0,30);
        //}
        //else if (rb.velocity.y < 0)
        //{
        //    transform.eulerAngles = new Vector3(0, 0, -30);
        //}
        //else
        //{
        //    transform.eulerAngles = new Vector3(0, 0, 0);
        //}
        // new method

        transform.eulerAngles = new Vector3(0,0,rb.velocity.y * RotatePower);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Pipe"))
        {
            Die();
        }
    }
    void Die()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}   
