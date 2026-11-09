using UnityEngine;

public class MainMenuInitialization : MonoBehaviour
{
    public GameObject tilePrefab;
    System.Random rnd;
    Vector3 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = -8; i <= 8; i = i + 2){
            for (int j = -4; j <= 4; j = j + 2){
                //backgroundTile = tilePrefab;
                GameObject tile = Instantiate<GameObject>(tilePrefab);
                position = new Vector3(i, j, 0);
                tile.transform.position = position;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
