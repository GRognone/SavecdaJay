import {InitialFlights} from "./initialFlights.js";
import {Table} from "./table.js"

let initialFlights = new InitialFlights();

await initialFlights.getFlights();


let flightTable = new Table(initialFlights);

flightTable.generateBody();

document.getElementById("id").addEventListener("click",(e)=> {flightTable.generateBody(initialFlights.sortFlightById(console.log()))});



// créattraitement de la zone recherche 

document.getElementById("Search").addEventListener("input", async (e) => {
 // contient la valeur du champ lorsque l'evenement est déclenché
    let searchFiledValue = e.target.value;

    await initialFlights.searchByCompany(searchFiledValue);

    flightTable.generateBody();
 })
