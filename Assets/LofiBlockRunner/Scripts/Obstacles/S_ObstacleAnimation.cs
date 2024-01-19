using UnityEngine;

/// <summary>  
/// Handle obstacle animation on game over
/// </summary>
public class S_ObstacleAnimation : MonoBehaviour
{
    #region Variables
    [Header("Shader Config")]
    [Tooltip("Select the shader material")]
    [SerializeField] private Material _material;
    private float _startDelay = 2.5f;
    private float _speed = 0.025f;
    private float _counter = 0.15f;
    #endregion

    #region Methods
    private void Awake() => S_Actions.Obstacle_Animate += StartAnimation;

    private void OnDestroy() => S_Actions.Obstacle_Animate -= StartAnimation;

    private void StartAnimation() => InvokeRepeating(nameof(ApplyDissolve), _startDelay, _speed);

    private void ApplyDissolve()
    {
        _counter += 0.01f;
        _material = GetComponent<Renderer>().material;
        _material.SetFloat("_Dissolve", _counter);
    }
    #endregion
}
