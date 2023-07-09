import {Db} from "./db.js";
import {Flight} from "./flight.js";

/*Gère la collection des vols*/
class InitialFlights{

    /**
     * Constructeur
     * initialise le tableau de données
     */
    constructor()
    {
        this.flightsCollection = [];
        // valeur par défaut du sens de tri, si initialisé en true asc sinon desc
        this.sortedAsc = true;
    }
    

    /**
    * Chargement des données de la collection
    */
    async getFlights()
    {
        this.flightsCollection = await Db.fetchData("https://arfp.github.io/tp/web/frontend/flights/flights.json");
       
        //pour chaque élément de la collection crée une instance de flight
       this.flightsCollection = this.flightsCollection.map(f => new Flight(f));
    }

    /* tri des vols par id*/
    sortFlightById()
    {
        let array = this.flightsCollection.sort((a,b)=>a.flight_id - b.flight_id);
        this.bool=!this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }

    /*tri des vols par ville de départ*/
    sortByStartCity()
    {
        let array= this.flightsCollection.sort((a,b)=>a.start_city.localeCompare(b.start_city));
        this.bool=!this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }

    /*tri des vols par ville d'arrivée*/
    sortByArrivalCity()
    {
        let array= this.flightsCollection.sort((a,b)=>a.arrival_city.localeCompare(b.arrival_city));
        this.bool =! this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }

    /*tri par heure de départ*/
    sortByDepartureHours()
    {
        let array = this.flightsCollection.sort((a,b)=> a.start_time.localeCompare(b.start_time));
        this.bool =! this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }
    /*tri par heure d'arrivée*/
    sortByArrivalHours()
    {
        let array= this.flightsCollection.sort((a,b)=>a.arrival_time.localeCompare(b.arrival_time));
        this.bool=!this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }
    /*tri par durée de vol*/
    sortByDuration()
    {
        let array= this.flightsCollection.sort((a,b)=>a.flight_duration - b.flight_duration);
        this.bool=!this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }
    /*tri par nom de companie aérienne*/
    sortByCompany()
    {
        let array= this.flightsCollection.sort((a,b)=>a.airline_name.localeCompare(b.airline_name));
        this.bool =! this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }
    /*tri par marque d'avion*/
    sortByPlaneMarker()
    {
        let array = this.flightsCollection.sort((a,b)=>a.plane_maker.localeCompare(b.plane_maker));
        this.bool =! this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }

    /*tri par model d'avion*/
    sortByPlaneRef()
    {
        let array = this.flightsCollection.sort((a,b)=>toString(a.plane_ref).localeCompare(toString(b.plane_ref)));
        this.bool =! this.bool;
        if (this.bool){
            return array.reverse();
        }
        return array;
    }

    /*tri par type d'avion*/
    sortByPlaneType()
    {
        let array = this.flightsCollection.sort((a,b)=>a.plane_type - b.plane_type);
        this.bool =! this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }
    /*tri par capacité*/
    SortByPlaneCapacity()
    {
        let array = this.flightsCollection.sort((a,b)=>a.plane_capacity - b.plane_capacity);
        this.bool =! this.bool;
        if(this.bool){
            return array.reverse();
        }
        return array;
    }

    /*tri par nombre se sièges occupés*/
    sortBySeatFree()
    {
        let array = this.flightsCollection.sort((a,b)=>a.seats_free -b.seats_free);
        this.bool=! this.bool;
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