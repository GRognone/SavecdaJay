import {InitialFlights} from "./initialFlights.js";
import {Table} from "./table.js"

let initialFlights = new InitialFlights();

await initialFlights.getFlights();


let flightTable = new Table(initialFlights);

flightTable.generateBody();