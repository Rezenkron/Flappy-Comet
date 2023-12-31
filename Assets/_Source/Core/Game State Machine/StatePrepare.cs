using UnityEngine;

public class StatePrepare : AGameState
{
    private IInputHandler inputHandler;
    private APlayer player;
    public StatePrepare(IInputHandler inputHandler, APlayer player)
    {
        this.inputHandler = inputHandler;
        this.player = player;
    }
    public override void Enter()
    {
        inputHandler.OnInputClick += GoToGame;
        player.Prepare();
    }

    public override void Exit()
    {
        inputHandler.OnInputClick -= GoToGame;
    }

    private void GoToGame()
    {
        stateMachine.ChangeState<StateGame>();
    }
}
