using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject tem = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = tem.transform.GetChild(1).transform.position;

    }

    // Start is called before the first frame update
    void Start() 
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }

}
