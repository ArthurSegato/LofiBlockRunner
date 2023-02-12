using UnityEngine;

public class S_ObstacleDestroyer : MonoBehaviour
{
    #region Variables
    [Header("Shader Config")]
    [Tooltip("Select the shader material")]
    [SerializeField] private Material _material;
    private float _startDelay = 2.5f;
    private float _speed = 0.025f;
    private float counter = 0.15f;
    #endregion

    #region Functions
    private void OnEnable()
    {
        S_Actions.HiddeObstacles += StartInvoke;
        S_Actions.DestroyObstacles += DestroyObstacles;
    }
    private void DestroyObstacles()
    {
        S_Actions.DestroyObstacles -= DestroyObstacles;
        S_Actions.HiddeObstacles -= StartInvoke;
        Destroy(transform.parent.gameObject);
    }

    private void StartInvoke()
    {
        InvokeRepeating(nameof(ApplyDissolve), _startDelay, _speed);
    }

    private void ApplyDissolve()
    {
        counter += 0.01f;
        _material = GetComponent<Renderer>().material;
        _material.SetFloat("_Dissolve", counter);
    }
    #endregion
}
