import { makeAutoObservable, reaction, runInAction } from "mobx";
import { Maximas } from "../models/maximas";
import agent from "../api/agent";
import { store } from "./store";
import { Pagination, PagingParams } from "../models/pagination";

export default class MaximasStore {
  maximasRegistry = new Map<string, Maximas>();
  selectedMaximas?: Maximas = undefined;
  editMode = false;
  loading = false;
  loadingInitial = false;
  pagination: Pagination | null = null;
  pagingParams = new PagingParams();
  predicate = new Map().set("all", true);

  constructor() {
    makeAutoObservable(this);

    reaction(
      () => this.predicate.keys(),
      () => {
        this.pagingParams = new PagingParams();
        this.maximasRegistry.clear();
        this.loadMaximas();
      }
    );
  }

  setPagingParams = (pagingParams: PagingParams) => {
    this.pagingParams = pagingParams;
  };

  get axiosParams() {
    const params = new URLSearchParams();
    params.append("pageNumber", this.pagingParams.pageNumber.toString());
    params.append("pageSize", this.pagingParams.pageSize.toString());

    return params;
  }

  private setMaximas = (maximas: Maximas) => {
    this.maximasRegistry.set(maximas.id, maximas);
  };

  loadMaximas = async () => {
    this.loadingInitial = true;
    try {
      console.log("tem o que aqui no maxima?", this.axiosParams);

      const result = await agent.Maxima.list(this.axiosParams);
      result.data.forEach((maximas) => {
        this.setMaximas(maximas);
      });
      this.setPagination(result.pagination);
      this.setLoadingInitial(false);
    } catch (error) {
      console.log(error);
      this.setLoadingInitial(false);
    }
  };

  setPagination = (pagination: Pagination) => {
    this.pagination = pagination;
  };

  setLoadingInitial = (state: boolean) => {
    this.loadingInitial = state;
  };
}
