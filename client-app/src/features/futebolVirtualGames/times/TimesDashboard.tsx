import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";
import { useEffect, useState } from "react";
import moment from "moment-timezone";
// import { FutebolVirtualGames } from "../../../app/models/futebolVirtualGames";
import { Label } from "semantic-ui-react";
import { GameTimes } from "../../../app/models/gameTimes";

// type TournamentValues = {
//   euroCup: string;
//   copaDoMundo: string;
//   premierShip: string;
//   superLeague: string;
// };

export default observer(function TimesDashboard() {
  const { FutebolVirtualStore } = useStore();
  const { loadFutebolVirtualGames } = FutebolVirtualStore;

  const [selectedHours, setSelectedHours] = useState("12");
  const [selectedMarket, setSelectedMarket] = useState("GOLSPAR");
  const [selectedTournament, setSelectedTournament] = useState("20700663");
  const [games, setGames] = useState<GameTimes[]>([]);

  // const tournamentValues: TournamentValues = {
  //   euroCup: "20700663",
  //   copaDoMundo: "20120650",
  //   premierShip: "20120653",
  //   superLeague: "20849528",
  // };

  const handleTournamentButtonClick = async (tournament: string) => {
    // const tournamentValue = tournamentValues[tournament];

    // const { initialDate, finalDate } = adjustDate(selectedHours);
    const gamesData = await loadFutebolVirtualGames(
      selectedTournament,
      selectedMarket,
      selectedHours
    );
    console.log(gamesData)
    gamesData ? setGames(gamesData) : console.log("ihh rapaz");
    // console.log(games)
  };

  // function adjustDate(hour: string) {
  //   const date = moment();
  //   const timeZone = "Europe/London";

  //   const finalDate = date.tz(timeZone).format();
  //   const initialDate = date.subtract(hour, "hours").tz(timeZone).format();

  //   return { initialDate, finalDate };
  // }

  
  const handleChangeTime = (event: React.ChangeEvent<HTMLSelectElement>) => {
    setSelectedHours(event.target.value);
  };
  
  const handleChangeMarket = (event: React.ChangeEvent<HTMLSelectElement>) => {
    setSelectedMarket(event.target.value);
  };

  useEffect(() => {
    handleTournamentButtonClick(selectedTournament);
    loadFutebolVirtualGames(
      selectedTournament,
      selectedMarket,
      selectedHours
    );
  }, [
    selectedTournament,
    selectedMarket,
    selectedHours,
  ]);

  return (
    <>
      <div>
        <h1>Times Dashboard</h1>
      </div>
      <div>
        <button onClick={() => setSelectedTournament("20700663")}>
          Euro Cup
        </button>
        <button onClick={() => setSelectedTournament("20120650")}>
          Copa do Mundo
        </button>
        <button onClick={() => setSelectedTournament("20120653")}>
          Premier Ship
        </button>
        <button onClick={() => setSelectedTournament("20849528")}>
          Super League
        </button>
      </div>

      <label htmlFor="timeChoese">Escolha uma opção:</label>
      <select id="timeChoese" value={selectedHours} onChange={handleChangeTime}>
        <option value="3">3 horas</option>
        <option value="6">6 horas</option>
        <option value="9">9 horas</option>
        <option value="12">12 horas</option>
        <option value="24">24 horas</option>
        <option value="72">72 horas</option>
        <option value="96">96 horas</option>
      </select>

      <label htmlFor="marketChoese">Escolha uma opção:</label>
      <select id="marketChoese" value={selectedMarket} onChange={handleChangeMarket}>
        <option value="GOLSPAR">GOLS PAR</option>
        <option value="GOLSIMPAR">GOLS IMPAR</option>
        <option value="OVER05">OVER 0,5</option>
        <option value="OVER15">OVER 1,5</option>
        <option value="OVER25">OVER 2,5</option>
        <option value="OVER35">OVER 3,5</option>
        <option value="UNDER05">UNDER 0,5</option>
        <option value="UNDER15">UNDER 1,5</option>
        <option value="UNDER25">UNDER 2,5</option>
        <option value="UNDER35">UNDER 3,5</option>
      </select>

      {games.length > 0 ? (
        games.map((game) => (
          <Label key={1+1} color={game ? "red" : "green"}>
            {`${game}`}
          </Label>
        ))) : (<p>ih rapaz</p>)}
      {/* {console.log(`Isso é do games: ${games.values}`)} */}
      
    </>
  );
});
