import { Guid } from 'guid-typescript';
import { City } from './city-interface';
import { Theme } from './theme-interface';

export interface Event {
  Id: Guid;
  Title: string;
  Address?: string | null;
  Description?: string | null;
  ImagePath?: string | null;
  StartDate?: Date | null;
  EndDate?: Date | null;
  CityId: number;
  City: City;
  ThemeId: number;
  Theme: Theme;
}
