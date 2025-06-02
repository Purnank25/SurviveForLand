using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(enemyPrefab, new Vector3(0, 0, 0),enemyPrefab.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
