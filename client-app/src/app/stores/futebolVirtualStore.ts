import { makeAutoObservable, reaction, runInAction } from "mobx";
import agent from "../api/agent"; // Import the FutebolVirtual class
import { Pagination, PagingParams } from "../models/pagination";
import { FutebolVirtualGames } from "../models/futebolVirtualGames";

export default class FutebolVirtualStore {
  // load the FutebolVirtualGames ordered by date descending withouth pagination
  futebolVirtualGamesRegistry = new Map<string, FutebolVirtualGames>();
  selectedFutebolVirtualGame?: FutebolVirtualGames = undefined;
  loading = false;
  loadingInitial = false;
  pagination: Pagination | null = null;
  pagingParams = new PagingParams();
  predicate = new Map().set("startDate", new Date());

  constructor() {
    makeAutoObservable(this);

    reaction(
      () => this.predicate.keys(),
      () => {
        this.pagingParams = new PagingParams();
        this.futebolVirtualGamesRegistry.clear();
        this.loadFutebolVirtualGames();
      }
    );
  }

  private setFutebolVirtualGame = (futebolVirtualGame: FutebolVirtualGames) => {
    this.futebolVirtualGamesRegistry.set(
      futebolVirtualGame.id,
      futebolVirtualGame
    );
    this.futebolVirtualGamesRegistry.forEach((test) =>
      console.log("alou", test)
    );
  };

  setLoadingInitial = (state: boolean) => {
    this.loadingInitial = state;
  };

  setPredicate = (predicate: string, value: string | Date) => {
    const resetPredicate = () => {
      this.predicate.forEach((value, key) => {
        if (key !== "startDate") this.predicate.delete(key);
      });
    };
    switch (predicate) {
      case "all":
        resetPredicate();
        this.predicate.set("all", true);
        break;
      case "isGoing":
        resetPredicate();
        this.predicate.set("isGoing", true);
        break;
      case "isHost":
        resetPredicate();
        this.predicate.set("isHost", true);
        break;
      case "startDate":
        this.predicate.delete("startDate");
        this.predicate.set("startDate", value);
        break;
    }
  };

  get axiosParams() {
    const params = new URLSearchParams();

    this.predicate.forEach((value, key: string) => {
      if (key === "startDate") {
        params.append(key, value.toISOString());
      } else {
        params.append(key, value);
      }
    });
    return params;
  }

  get futebolVirtualGamesByDate() {
    return Array.from(this.futebolVirtualGamesRegistry.values()).sort(
      (a, b) => a.date!.getTime() - b.date!.getTime()
    );
  }

  // Get the FutebolVirtualGames ordered by date descending withouth pagination
  loadFutebolVirtualGames = async (
    initialDate: string = "",
    finalDate: string = "",
    leagueId: string = ""
  ) => {
    this.loadingInitial = true;
    try {
      const result = await agent.FutebolVirtualGame.list(
        initialDate,
        finalDate,
        leagueId
      );

      return result;

      // result.forEach((futebolVirtualGame) =>
      //   this.setFutebolVirtualGame(futebolVirtualGame)
      // );
      // return this.futebolVirtualGamesRegistry;
    } catch (error) {
      console.log(error);
      runInAction(() => {
        this.setLoadingInitial(false);
      });
    }
  };
}
