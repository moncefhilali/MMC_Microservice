import { Guid } from 'guid-typescript';

export interface Speaker {
  id: Guid;
  firstname: string;
  lastname: string;
  email: string;
  phone: string;
  gender: string;
  picturePath: string;
  mvp?: boolean;
  mct?: boolean;
  description: string;
  facebook: string;
  instagram: string;
  linkedIn: string;
  twitterX: string;
  userId: Guid;
}
