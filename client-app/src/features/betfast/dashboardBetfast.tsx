import { observer } from "mobx-react-lite";

export default observer(function DashboardBetfast() {
  return (
    <iframe 
      title="Betfast" 
      src="https://s5.sir.sportradar.com/starworldgamesvirtuals/br/1/season/2803974/archive" 
      width="100%" height="800"></iframe>
  )
});