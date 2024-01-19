using UnityEngine;

/// <summary>  
/// Handles obstacle spawning.
/// </summary>
public class S_ObstacleSpawner : MonoBehaviour
{
    #region Variables
    [Header("Spawner Settings")]
    [Tooltip("List with all obstacles to be spawned.")]
    [SerializeField] private GameObject[] _obstacles;
    [Tooltip("How many seconds to wait before start spawning obstacles.")]
    [SerializeField] private float _spawnDelay = 0.0f;
    [Tooltip("Interval in seconds between spawning of each obstacle.")]
    [SerializeField] private float _spawnInterval = 0.0f;
    //teste
    #endregion

    #region Methods
    private void Awake()
    {
        S_Actions.Obstacle_Enable_Manager += () => this.gameObject.SetActive(true);
        S_Actions.Obstacle_Disable_Manager += () => this.gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        S_Actions.Obstacle_Enable_Manager -= () => this.gameObject.SetActive(true);
        S_Actions.Obstacle_Disable_Manager -= () => this.gameObject.SetActive(false);
    }

    // Starts obstacle spawning when becomes enabled
    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnObstacles), _spawnDelay, _spawnInterval);
        //S_Actions.ObstacleSpawnedFlag();
    }

    // Stop obstacle spawning when becomes disabled
    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnObstacles));
        //S_Actions.ObstacleDestroyedFlag();
    }

    // Spawn random obstacle
    private void SpawnObstacles() {
        int index = Random.Range(0, _obstacles.Length);

        Instantiate(_obstacles[index], SpawnPosition(index), this.transform.rotation);
    }

    // Define obstacle position
    private Vector3 SpawnPosition(int index)
    {
        Vector3 position = this.transform.position;

        if (index == 0) position += new Vector3(Random.Range(-2.5f, 2.5f), 0.0f, 0.0f);

        if(index == 1) position += new Vector3(Random.Range(-4.5f, 4.5f), 0.0f, 0.0f);
        
        return position;
    }
    #endregion
}
