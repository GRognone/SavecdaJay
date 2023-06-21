import { Cereales } from "./cereales.js"

class Table
{
    constructor(cerealeTable)
    {
        this.cereales = cerealeTable;
        this.tBody = document.getElementById("tableBody");
    }

    generateBody()
    {
        for(let cereale of this.cereales.cerealesCollection)
        {
            let row = document.createElement('tr');
            this.tBody.appendChild(row);
            this.generateCell(row, cereale.id);
            this.generateCell(row, cereale.name);
            this.generateCell(row, cereale.calories);
            this.generateCell(row, cereale.protein);
            this.generateCell(row, cereale.sodium);
            this.generateCell(row, cereale.fiber);
            this.generateCell(row, cereale.carbo);
            this.generateCell(row, cereale.sugars);
            this.generateCell(row, cereale.potass);
            this.generateCell(row, cereale.vitamins);
            this.generateCell(row, cereale.rating);
            this.generateCell(row, cereale.ns);
            this.generateCell(row, cereale.del);

        }
    }

    generateCell(row,data)
    {
        let cell = document.createElement('td');
        cell.textContent = data;
        row.appendChild(cell);

    }
}

export{Table};