

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bird : MonoBehaviour
{
    public float jumpSpeed;
    public float rotatePower;
    public float speed;
    public TMP_Text scoreText;
    public GameObject endscreen;
    //============================
    public GameObject yl, rd, blu;
    //============================
    public GameObject day, night;


    int score;
    float rng;
    float rngBG;
    Rigidbody2D rb;





    void Start()
    {
        rng = UnityEngine.Random.value;
        rb = GetComponent<Rigidbody2D>();
        rngBG = UnityEngine.Random.value;
        Pipe.speed = speed;
        if (rng <= 0.3) { yl.SetActive(true); }

        else if (rng >= 0.3 && rng < 0.6) { rd.SetActive(true); }

        else { blu.SetActive(true); }

        /*==========================================================*/
        if (rngBG > 0.5) { night.SetActive(true); }
        else { day.SetActive(true); }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * rotatePower);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        scoreText.text = score.ToString();
    }

    void Die()
    {
        Pipe.speed = 0;
        jumpSpeed = 0;
        rb.velocity = Vector2.zero;

        GetComponentInChildren<Animator>().enabled = false;
        Invoke("ShowMenu",1f);

        //var sceneName = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(sceneName);
    }
    void ShowMenu()
    {
        endscreen.SetActive(true);
        scoreText.gameObject.SetActive(false);

    }
}   
