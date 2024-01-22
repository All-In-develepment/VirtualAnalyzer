import { useEffect, useState } from "react";
import { useStore } from "../../../app/stores/store";
import { observer } from "mobx-react-lite";
import { ILastGames } from "../../../app/models/lastGames";
import moment from "moment-timezone";

export default observer(function LastGames() {
  const { LastGames } = useStore();
  const { loadLastGames } = LastGames;

  const [data, setData] = useState<ILastGames[]>();

  async function handleEffect() {
    const date = moment().format("YYYY-MM-DD");

    const lastGamesData = await loadLastGames(date);

    lastGamesData ? setData(lastGamesData) : console.log("ihh rapaz");
  }

  useEffect(
    () => {
      handleEffect();
    },
    // eslint-disable-next-line react-hooks/exhaustive-deps
    []
  );

  return (
    <>
      {data &&
        data.map((game) => (
          <div key={game.id}>
            <div>{game.competition}</div>
            <div>
              {game.matches.map((match, index) => (
                <div key={index}>{match.sumScore}</div>
              ))}
            </div>
          </div>
        ))}
    </>
  );
});
