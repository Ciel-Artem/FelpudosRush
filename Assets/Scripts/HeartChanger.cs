
using UnityEngine;

public class HeartChanger : MonoBehaviour
{
    public GameObject brokenHearts;
    public GameObject normalHearts;

    private bool changed = false;

    private void Start()
    {
        brokenHearts.SetActive(true);
        normalHearts.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !changed)
        {
            brokenHearts.SetActive(false);
            normalHearts.SetActive(true);

            changed = true;
        }
    }
}
