using FootballPlayerAPI.Models;

namespace FootballPlayerAPI.Services.FootballPlayerService;

public class FootballPlayerService : IFootballPlayerService
{
    private static List<FootballPlayer> footballPlayers = new List<FootballPlayer>
    {
        new FootballPlayer { Id=1, FirstName="George", LastName="Kittle", Number=85, Position="TE", TeamName="Sanfansico 49ers"},
        new FootballPlayer { Id=2, FirstName="Deebo", LastName="Samuel", Number=19, Position="WR", TeamName="Sanfransico 49ers"},
        new FootballPlayer { Id=3, FirstName="Brandon", LastName="Aiyuk", Number=11, Position="WR", TeamName="Sanfransico 49ers"},
    };

    public FootballPlayerService()
    {
        
    }

    public List<FootballPlayer> GetFootballPlayers()
    {
        return footballPlayers;
    }

    public FootballPlayer GetFootballPlayer(int Id)
    { 
        var footballPlayer = footballPlayers.Find(x => x.Id == Id);
        if (footballPlayer == null)
        {
            return null;
        }
        return footballPlayer;
    }

    public FootballPlayer CreateFootballPlayer(FootballPlayer footballPlayer) 
    {
        footballPlayers.Add(footballPlayer);
        if (footballPlayer == null ) 
        {
            return null;
        }
        return footballPlayer;
    }

    public FootballPlayer UpdateFootballPlayer(int Id, FootballPlayer request)
    {
        var footballPlayer = footballPlayers.Find(x => x.Id == Id);
        if (footballPlayer == null)
        {
            return null;
        }
        footballPlayer.FirstName = request.FirstName;
        footballPlayer.LastName = request.LastName;
        footballPlayer.Number = request.Number;
        footballPlayer.Position = request.Position;
        footballPlayer.TeamName = request.TeamName;
        return footballPlayer;
    }

    public List<FootballPlayer> DeleteFootballPlayer(int Id)
    {
        var footballPlayer = footballPlayers.Find(x => x.Id == Id);
        if (footballPlayer == null)
        {
            return null;
        }
        footballPlayers.Remove(footballPlayer);
        return footballPlayers;
    }
}
