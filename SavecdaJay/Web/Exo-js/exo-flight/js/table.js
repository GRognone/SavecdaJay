class Table 
{
    constructor(flightTable)
     {
        this.initialFlights = flightTable;
        this.tBody = document.getElementById("tableBody");
    }

    generateBody() {
        let array = this.initialFlights.flightsCollection
        console.log(this.initialFlights)
        this.tBody.innerHTML = ""

        for (let flight of array) {
            let row = document.createElement('tr');
            row.className = "tablebodyTr";
            this.tBody.appendChild(row);
            this.generateCell(row, flight.flight_id);
            this.generateCell(row, flight.start_city);
            this.generateCell(row, flight.arrival_city);
            this.generateCell(row, flight.start_time);
            this.generateCell(row, flight.arrival_time);
            this.generateCell(row, flight.flight_duration);
            this.generateCell(row, flight.airline_name);
            this.generateCell(row, flight.plane_maker);
            this.generateCell(row, flight.plane_ref);
            this.generateCell(row, flight.plane_type);
            this.generateCell(row, flight.plane_capacity);
            this.generateCell(row, flight.seats_free);
            this.generateCell(row, flight.travelTime);

        }
    }

    generateCell(row, flights) {
        let cell = document.createElement('td');
        cell.className = "cellData";
        cell.textContent = flights;
        cell.dataset.val = flights;
        row.appendChild(cell);
    }


    
}
export {Table};