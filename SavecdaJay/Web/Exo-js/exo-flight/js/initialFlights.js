import {Db} from "./db.js";
import {Flight} from "./flight.js";

class InitialFlights{

    constructor()
    {
        this.flightsCollection = [];
    }
    


    async getFlights()
    {
        this.flightsCollection = await Db.fetchData("https://arfp.github.io/tp/web/frontend/flights/flights.json");
        /*for(let flight of flightToAdd.flights)
        {
            this.flightsCollection.push(new Flight(flight));
        }*/
    }
}
export{InitialFlights};