public class S_IntroState : S_GameBaseState
{
    S_GameStateManager gameState;
    public override void EnterState(S_GameStateManager gameState)
    {
        S_Actions.OnPlayIntro();
    }

    public override void LeaveState(S_GameStateManager gameState)
    {

    }

    private void OnEnable() => S_Actions.OnIntroFinished += ChangeState;

    private void ChangeState() {
        
        gameState.SwitchState(gameState.titleScreenState);
    }  
}
