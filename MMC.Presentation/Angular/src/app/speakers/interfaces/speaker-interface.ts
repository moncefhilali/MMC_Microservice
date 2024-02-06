import { Guid } from 'guid-typescript';

export interface Speaker {
  Id: Guid;
  Firstname: string;
  Lastname: string;
  Email: string;
  Phone: string;
  Gender: string;
  PicturePath: string;
  MVP?: boolean;
  MCT?: boolean;
  Description: string;
  Facebook: string;
  Instagram: string;
  LinkedIn: string;
  TwitterX: string;
  UserId: Guid;
}
