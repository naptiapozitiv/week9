using week9;

GameParameters parameters = new GameParameters();
parameters.ChooseGameMode();
parameters.ChooseGameLevel();
parameters.SetUpLimit();

Game gameInstance;

switch (parameters.Mode)
{
    case "T":
        gameInstance = new TimeLimitedGame(parameters.Limit);
        break;
    case "N":
        gameInstance = new GuessesLimitGame(parameters.Limit);
        break;
    default:
        throw new ArgumentException("Invalid game mode.");
}

gameInstance.StartGame();