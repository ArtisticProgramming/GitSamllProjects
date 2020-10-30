import { TastingRating } from "./TastingRating";
import { PlaceLocation } from "./PlaceLocation";

export class Coffee {

    // Properties
    type: string;
    rating: number;
    notes: string;
    tastingRating: TastingRating;

    constructor(public name: string, public place: string, 
                public location: PlaceLocation) {

    }

}