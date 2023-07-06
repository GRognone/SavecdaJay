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
       
        //pour chaque élément de la collection crée une instance de flight
       this.flightsCollection = this.flightsCollection.map(f => new Flight(f));
    }

    sortFlightById()
    {
        let array = this.flightsCollection.sort((a,b)=>a.flight_id - b.flight_id);
        this.bool=!this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }

    /* recherche d'un vol par compagnie */
    async searchByCompany(val)
    {
        await this.getFlights()
        val= val.trim();// supprime les espaces vides
        if(val.length>0)
        {
            val = val.toLowerCase();
            this.flightsCollection = this.flightsCollection.filter(flight => flight.airline_name.toLowerCase().includes(val));
            console.log(val);
        }
    }
}
export{InitialFlights};