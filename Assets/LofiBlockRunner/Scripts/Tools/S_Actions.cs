using System;

/// <summary>  
/// Class containing all game actions
/// </summary>
public static class S_Actions
{
    #region States
    public static Action OpenTutorial;

    public static Action OpenGame;

    public static Action EndGame;

    public static Action PauseGame;

    public static Action OpenTitleScreen;

    public static Action OpenOptions;

    public static Action OpenCredits;
    #endregion

    #region Obstacles
    public static Action EnableObstacleManager;

    public static Action DisableObstacleManager;

    public static Action DestroyObstacles;

    public static Action HiddeObstacles;

    public static Action DisableObstacleMovement;

    public static Action ObstacleSpawnedFlag;

    public static Action ObstacleDestroyedFlag;
    #endregion

    #region Player
    public static Action ResetPlayer;

    public static Action BrakePlayer;

    public static Action EnablePlayerInput;

    public static Action DisablePlayerInput;

    public static Action EnablePlayerCollision;

    public static Action DisablePlayerCollision;

    public static Action EnablePlayerPause;

    public static Action DisablePlayerPause;

    public static Action EnablePlayerTutorial;

    public static Action DisablePlayerTutorial;
    #endregion

    #region Camera
    public static Action EnableTitleScreenCamera;

    public static Action DisableTitleScreenCamera;

    public static Action EnableOptionsCamera;

    public static Action DisableOptionsCamera;

    public static Action EnableCreditsCamera;

    public static Action DisableCreditsCamera;

    public static Action EnablePlayerCamera;

    public static Action DisablePlayerCamera;
    #endregion

    #region UI
    public static Action EnableTitleScreenUI;

    public static Action DisableTitleScreenUI;

    public static Action EnableOptionsUI;

    public static Action DisableOptionsUI;

    public static Action EnableCreditsUI;

    public static Action DisableCreditsUI;

    public static Action EnableGameUI;

    public static Action DisableGameUI;

    public static Action EnableEndScreenUI;

    public static Action DisableEndScreenUI;

    public static Action EnablePauseUI;

    public static Action DisablePauseUI;

    public static Action EnableTutorialUI;

    public static Action DisableTutorialUI;
    #endregion
}
