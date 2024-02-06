import { Guid } from 'guid-typescript';
import { City } from './city-interface';
import { Theme } from './theme-interface';

export interface Event {
  Id: Guid;
  title: string;
  address?: string | null;
  description?: string | null;
  imagePath?: string | null;
  startDate?: Date | null;
  endDate?: Date | null;
  cityId: number;
  city: City;
  themeId: number;
  theme: Theme;
}
