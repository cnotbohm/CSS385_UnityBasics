using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private Rigidbody2D rb2d;
    private Collider2D boxCollider2D;
    [SerializeField] private LayerMask deathTriangleLayerMask;

    public GameObject canvas;
    public HealthBar healthBar;

    private void Start()
    {
        rb2d = rb2d = GetComponent<Rigidbody2D> ();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (IsTouching())
        {
            currentHealth -= 1;
            healthBar.SetHealth(currentHealth);
        }
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
            canvas.SetActive(true);
        }
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private bool IsTouching() {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, deathTriangleLayerMask);
        return raycastHit2D.collider != null;
    }
}
