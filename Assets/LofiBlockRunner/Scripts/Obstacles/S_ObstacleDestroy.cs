using UnityEngine;

/// <summary>  
/// Handle obstacle destruction on game over
/// </summary>
public class S_ObstacleDestroy : MonoBehaviour
{
    #region Methods
    private void Awake() => S_Actions.Obstacle_Destroy += DestroyObstacle;
    private void OnDestroy() => S_Actions.Obstacle_Destroy -= DestroyObstacle;
    private void DestroyObstacle() => Destroy(transform.parent.gameObject);
    #endregion
}
