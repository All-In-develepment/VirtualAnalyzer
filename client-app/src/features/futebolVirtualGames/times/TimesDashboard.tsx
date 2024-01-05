import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";
import { useEffect } from "react";

export default observer(function TimesDashboard() {
    const { FutebolVirtualStore } = useStore();
    const { loadFutebolVirtualGames } = FutebolVirtualStore;

    console.log("TimesDashboard");

    useEffect(() => {
        loadFutebolVirtualGames();
    }, [loadFutebolVirtualGames])
    
    return (
        <div>
            <h1>Times Dashboard</h1>
        </div>
    )
})