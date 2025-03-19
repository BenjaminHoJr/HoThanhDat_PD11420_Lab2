using UnityEngine;

public class EggController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject EggBroken;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name.Equals("platform"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if(col.gameObject.name.Equals("box"))
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
