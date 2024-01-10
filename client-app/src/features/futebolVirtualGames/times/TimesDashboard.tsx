import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";
import { useEffect, useState } from "react";
import moment from "moment-timezone";
import { FutebolVirtualGames } from "../../../app/models/futebolVirtualGames";

type TournamentValues = {
  euroCup: string;
  copaDoMundo: string;
  premierShip: string;
  superLeague: string;
};

export default observer(function TimesDashboard() {
  const { FutebolVirtualStore } = useStore();
  const { loadFutebolVirtualGames } = FutebolVirtualStore;

  const [selectedHours, setSelectedHours] = useState("3");
  const [games, setGames] = useState<FutebolVirtualGames[]>([]);

  const tournamentValues: TournamentValues = {
    euroCup: "20700663",
    copaDoMundo: "20120650",
    premierShip: "20120653",
    superLeague: "20849528",
  };

  const handleTournamentButtonClick = async (
    tournament: keyof TournamentValues
  ) => {
    const tournamentValue = tournamentValues[tournament];

    const { initialDate, finalDate } = adjustDate(selectedHours);
    const gamesData = await loadFutebolVirtualGames(
      initialDate,
      finalDate,
      tournamentValue
    );
    gamesData ? setGames(gamesData) : console.log("ihh rapaz");
  };

  function adjustDate(hour: string) {
    const date = moment();
    const timeZone = "Europe/London";

    const finalDate = date.tz(timeZone).format();
    const initialDate = date.subtract(hour, "hours").tz(timeZone).format();

    return { initialDate, finalDate };
  }

  //   useEffect(() => {
  //     loadFutebolVirtualGames();
  //   }, [loadFutebolVirtualGames]);

  const handleChange = (event: React.ChangeEvent<HTMLSelectElement>) => {
    setSelectedHours(event.target.value);
  };

  return (
    <>
      <div>
        <h1>Times Dashboard</h1>
      </div>
      <div>
        <button onClick={() => handleTournamentButtonClick("euroCup")}>
          Euro Cup
        </button>
        <button onClick={() => handleTournamentButtonClick("copaDoMundo")}>
          Copa do Mundo
        </button>
        <button onClick={() => handleTournamentButtonClick("premierShip")}>
          Premier Ship
        </button>
        <button onClick={() => handleTournamentButtonClick("superLeague")}>
          Super League
        </button>
      </div>

      <label htmlFor="mySelect">Escolha uma opção:</label>
      <select id="mySelect" value={selectedHours} onChange={handleChange}>
        <option value="3">3 horas</option>
        <option value="6">6 horas</option>
        <option value="9">9 horas</option>
        <option value="12">12 horas</option>
        <option value="24">24 horas</option>
        <option value="72">72 horas</option>
        <option value="96">96 horas</option>
      </select>

      {games &&
        games.map((game) => (
          <div key={game.id}>{`${game.finalTimeResult}`}</div>
        ))}
    </>
  );
});
