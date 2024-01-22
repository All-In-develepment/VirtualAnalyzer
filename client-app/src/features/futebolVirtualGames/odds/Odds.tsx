import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";
import { useEffect, useState } from "react";
import { IOdd } from "../../../app/models/odds";

export default observer(function Odds({ leagueId }: { leagueId: string }) {
  const { Odds } = useStore();
  const { loadOdds } = Odds;

  const [selectedLeague, setSelectedLeague] = useState<IOdd>();

  async function handleEffect(leagueId: string) {
    const odds = await loadOdds(leagueId);

    odds ? setSelectedLeague(odds) : console.log("ihh rapaz");
  }

  useEffect(
    () => {
      handleEffect(leagueId);
    },
    // eslint-disable-next-line react-hooks/exhaustive-deps
    []
  );

  return <>{selectedLeague && <div>{selectedLeague.data}</div>}</>;
});
