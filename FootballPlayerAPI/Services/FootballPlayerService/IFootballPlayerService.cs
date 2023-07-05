using FootballPlayerAPI.Models;

namespace FootballPlayerAPI.Services.FootballPlayerService;

public interface IFootballPlayerService
{
    List<FootballPlayer> GetFootballPlayers();
    FootballPlayer GetFootballPlayer(int Id);
    FootballPlayer CreateFootballPlayer(FootballPlayer footballPlayer);
    FootballPlayer UpdateFootballPlayer(int Id, FootballPlayer request);
    List<FootballPlayer> DeleteFootballPlayer(int Id);
}
