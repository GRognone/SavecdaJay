import {InitialFlights} from "./initialFlights.js";
import {Table} from "./table.js"

// création de l'instance qui gère la collection de données
let initialFlights = new InitialFlights();

// chargement des données 
await initialFlights.getFlights();

// création de l'instance qui gère la mise à jour de l'interface.
// on y injecte la collection de données
let flightTable = new Table(initialFlights);

// génération initiale du tableau HTML à partir des données de flightCollection
flightTable.generateBody();


document.getElementById("id").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortFlightById())});
document.getElementById("startCity").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortByStartCity())})
document.getElementById("arrivalCity").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortByArrivalCity())});
document.getElementById("startTime").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortByDepartureHours())});
document.getElementById("arrivalTime").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortByArrivalHours())});
document.getElementById("flightDuration").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortByDuration())});
document.getElementById("airlineName").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortByCompany())});
document.getElementById("planeMaker").addEventListener("click", (e)=> {flightTable.generateBody(initialFlights.sortByPlaneMarker())});
document.getElementById("planeRef").addEventListener("click", (e)=> {flightTable.generateBody(initialFlights.sortByPlaneRef())});
document.getElementById("planeType").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortByPlaneType())});
document.getElementById("planeCapacity").addEventListener("click",(e) =>{flightTable.generateBody(initialFlights.SortByPlaneCapacity())});
document.getElementById("seatsFree").addEventListener("click",(e) =>{flightTable.generateBody(initialFlights.sortBySeatFree())});
document.getElementById("travelTime").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortByDuration())});






// créattraitement de la zone recherche 

document.getElementById("Search").addEventListener("input", async (e) => {
 // contient la valeur du champ lorsque l'evenement est déclenché
    let searchFiledValue = e.target.value;

    await initialFlights.searchByCompany(searchFiledValue);

    flightTable.generateBody();
 })
