using System;

/// <summary>  
/// Class containing all game actions
/// </summary>
public static class S_Actions
{
    #region States
    public static Action OpenMainMenu;

    public static Action OpenGame;

    public static Action OpenSettings;

    public static Action OpenCredits;

    public static Action OpenTutorial;

    public static Action EndGame;

    public static Action PauseGame;
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
    public static Action EnableMainMenuCamera;

    public static Action EnableSettingsCamera;

    public static Action EnableCreditsCamera;

    public static Action EnableGameCamera;
    #endregion

    #region UI
    public static Action OpenMainMenuUI;

    public static Action OpenSettingsUI;

    public static Action OpenCreditsUI;

    public static Action OpenGameUI;

    public static Action OpenEndScreenUI;

    public static Action OpenPauseUI;

    public static Action OpenTutorialUI;
    #endregion
}
