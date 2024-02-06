interface Event {
  id: string;
  title: string;
  address?: string | null;
  description?: string | null;
  imagePath?: string | null;
  startDate?: Date | null;
  endDate?: Date | null;
  cityId: number;
  themeId: number;
}
