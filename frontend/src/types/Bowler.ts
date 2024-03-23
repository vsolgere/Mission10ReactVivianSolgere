export type Team = {
  teamId: number;
  teamName: string;
  // You can include other properties for the team if necessary
};

export type Bowler = {
  bowlerId: number;
  bowlerLastName?: string; // '?' denotes that the property is optional
  bowlerFirstName?: string;
  bowlerMiddleInit?: string;
  bowlerAddress?: string;
  bowlerCity?: string;
  bowlerState?: string;
  bowlerZip?: string;
  bowlerPhoneNumber?: string;
  teamId?: number;
  team?: Team; // Assuming you might need team details here
};
