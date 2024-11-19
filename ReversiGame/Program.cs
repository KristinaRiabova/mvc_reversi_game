using ReversiGame.Controllers;
using ReversiGame.Views;

namespace ReversiGame;

public class Program
{
    static void Main(string[] args)
    {
        IView view = new SimpleView();
        IGameController gameController = new GameController(view);
        MainView mainView = new MainView();
        while (true)
        {
            mainView.Display();
            string? input = mainView.GetPlayerInput();
            if (input == null) continue;
            switch (input)
            {
                case "PvP":
                    view = new SimpleView();
                    gameController = new GameController(view);
                    break;
                case "PvE":
                    view = new EnhancedView();
                    gameController = new BotGameController(view);
                    break;
            }
            gameController.StartGame();
        }
        
    }
}