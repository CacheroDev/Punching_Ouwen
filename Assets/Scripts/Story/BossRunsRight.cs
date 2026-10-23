

using UnityEngine;
using UnityEngine.SceneManagement;

public class BossRunsRight : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxDistance;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);

        if (transform.position.x > maxDistance)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
