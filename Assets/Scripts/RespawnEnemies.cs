using UnityEngine;

public class ParentController : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private int initialChildCount;
    private bool prefabSpawned = false;

    void Start()
    {
        // Get the initial number of children
        initialChildCount = transform.childCount;

        // If there are no initial children, instantiate the prefab
        if (initialChildCount == 0)
        {
            InstantiatePrefab();
        }
    }

    void Update()
    {
        // If all children are destroyed and the prefab is not currently spawned, instantiate the prefab
        if (transform.childCount == 0 && initialChildCount > 0 && !prefabSpawned)
        {
            InstantiatePrefab();
        }
    }

    void InstantiatePrefab()
    {
        // Calculate the center of the screen
        Vector3 screenCenter = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.4f, 10f)); // Assuming camera's near clip plane is at 10 units

        Instantiate(prefabToInstantiate, screenCenter, Quaternion.identity);

        // Reset the initial child count
        initialChildCount = prefabToInstantiate.transform.childCount;

        // indicate that the prefab is spawned
        prefabSpawned = true;
    }
}
